using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STM32_Generate_Linker_Sections
{
    public partial class MainForm : Form
    {
        private TreeNode previous_node;

        public MainForm()
        {
            InitializeComponent();
        }

        struct SectionInfo
        {
            public string name;
            public string origin_s;
            public UInt32 origin;
            public string length_s;
            public UInt32 length;
        }

        private SectionInfo? parseTreeName(string name)
        {
            string[] separator = { " - " };
            string[] name_split = name.Split(separator, StringSplitOptions.None);

            if (name_split.Length < 3) return null;

            string[] separator2 = { ": " };
            string origin_s = name_split[1].Split(separator2, StringSplitOptions.None)[1];
            string length_s = name_split[2].Split(separator2, StringSplitOptions.None)[1];

            UInt32 origin = Convert.ToUInt32(origin_s, 16);
            UInt32 length = Convert.ToUInt32(length_s, 16);

            SectionInfo info;
            info.name = name_split[0];
            info.origin_s = origin_s;
            info.origin = origin;
            info.length_s = length_s;
            info.length = length;

            return info;
        }

        void enableComponents(bool enable)
        {
            textBoxSectionOrigin.Enabled = enable;
            labelSectionOrigin.Enabled = enable;
            labelSectionOriginU.Enabled = enable;
            numericUpDownSectionOriginM.Enabled = enable;
            numericUpDownSectionOriginL.Enabled = enable;
            textBoxSectionName.Enabled = enable;
        }

        void updateOriginFromString(string origin_s)
        {
            textBoxSectionOrigin.Text = origin_s;

            try
            {
                UInt32 origin = Convert.ToUInt32(origin_s, 16);


                var diff = checked((Int64)origin) - 0x20000000;

                if (diff < 0)// origin is lower than ram origin
                {
                    labelSectionOriginU.Text = "0x08000000";
                    origin -= 0x08000000;
                }
                else
                {
                    labelSectionOriginU.Text = "0x20000000";
                    origin -= 0x20000000;
                }

                numericUpDownSectionOriginM.Value = origin / 1024;
                numericUpDownSectionOriginL.Value = origin % 1024;

                updateEnd();
            }
            catch (Exception)
            {

            }
        }

        void updateSizeFromString(string length_s)
        {
            textBoxSectionSize.Text = length_s;

            try
            {
                UInt32 length = Convert.ToUInt32(length_s, 16);


                if (checkBoxSectionSizeSubtractBytes.Checked)
                {
                    numericUpDownSectionSizeM.Value = (UInt32)Math.Ceiling((float)length / 1024);
                    var num = numericUpDownSectionSizeM.Value * 1024 - length;
                    numericUpDownSectionSizeL.Value = num;
                }
                else
                {
                    numericUpDownSectionSizeM.Value = length / 1024;
                    numericUpDownSectionSizeL.Value = length % 1024;
                }

                updateEnd();
            }
            catch (Exception)
            {
                return;
            }
        }

        void updateOriginFromSpinbox()
        {
            UInt32 origin = Convert.ToUInt32(labelSectionOriginU.Text, 16);
            origin += (UInt32)numericUpDownSectionOriginM.Value * 1024;
            origin += (UInt32)numericUpDownSectionOriginL.Value;

            var text = String.Format("0x{0:X8}", origin);
            textBoxSectionOrigin.Text = text;

            updateEnd();
        }

        void updateSizeFromSpinbox()
        {
            UInt32 origin = (UInt32)numericUpDownSectionSizeM.Value * 1024;

            if (checkBoxSectionSizeSubtractBytes.Checked)
            {
                origin -= (UInt32)numericUpDownSectionSizeL.Value;
            }
            else
            {
                origin += (UInt32)numericUpDownSectionSizeL.Value;
            }

            var text = String.Format("0x{0:X5}", origin);
            textBoxSectionSize.Text = text;

            updateEnd();
        }

        void updateEnd()
        {
            // add all spinboxes together
            UInt32 origin = Convert.ToUInt32(labelSectionOriginU.Text, 16);
            origin += (UInt32)numericUpDownSectionOriginM.Value * 1024;
            origin += (UInt32)numericUpDownSectionOriginL.Value;

            origin += (UInt32)numericUpDownSectionSizeM.Value * 1024;

            // add or subtract bytes depending on checkbox
            if (checkBoxSectionSizeSubtractBytes.Checked)
            {
                origin -= (UInt32)numericUpDownSectionSizeL.Value;
            }
            else
            {
                origin += (UInt32)numericUpDownSectionSizeL.Value;
            }

            var origin_s = String.Format("0x{0:X8}", origin);
            textBoxSectionEnd.Text = origin_s;

            var diff = checked((Int64)origin) - 0x20000000;

            if (diff < 0)// origin is lower than ram origin
            {
                labelSectionEndU.Text = "0x08000000";
                origin -= 0x08000000;
            }
            else
            {
                labelSectionEndU.Text = "0x20000000";
                origin -= 0x20000000;
            }

            numericUpDownSectionEndM.Value = origin / 1024;
            numericUpDownSectionEndL.Value = origin % 1024;
        }

        void recursiveGenerateLinkerCode(TreeNodeCollection nodes, bool writable)
        {
            if (nodes == null) return;

            for (var i = 0; i < nodes.Count; i++)
            {
                var nodeinfo = parseTreeName(nodes[i].Text);
                if (nodeinfo.HasValue)
                {

                    // add name
                    var info = nodeinfo.Value;
                    textBoxLinkerCode.Text += "  " + info.name + " ";

                    // add flags
                    if (writable)
                    {
                        textBoxLinkerCode.Text += "(xrw)";
                    }
                    else
                    {
                        textBoxLinkerCode.Text += "(rx)";
                    }

                    // add origin and length
                    textBoxLinkerCode.Text += " : ORIGIN = " + info.origin_s;
                    textBoxLinkerCode.Text += ", LENGTH = " + info.length_s;
                    textBoxLinkerCode.Text += "\r\n";
                }
                // recursively add children
                recursiveGenerateLinkerCode(nodes[i].Nodes, writable);
            }
        }

        void checkChildNodeSizes(TreeNode parent_section)
        {
            var info = parseTreeName(parent_section.Text);
            if (!info.HasValue) return;

            var last_section_end = info.Value.origin; // the next section must begin after the last section ends
            var parent_section_end = info.Value.origin + info.Value.length;

            foreach (TreeNode section in parent_section.Nodes)
            {
                info = parseTreeName(section.Text);

                if (!info.HasValue) continue;

                var current_section_origin = info.Value.origin;
                var current_section_end = info.Value.origin + info.Value.length;


                bool is_ok = true;

                if (current_section_origin < last_section_end) is_ok = false;
                if (current_section_end > parent_section_end) is_ok = false;

                last_section_end = current_section_end; // update info about last section so we can detect intersections (no pun indented)

                if (!is_ok)
                {
                    section.BackColor = Color.Red;
                }
                else // children sizes are ok
                {
                    // restore background color
                    section.BackColor = (section == treeView1.SelectedNode) ? SystemColors.Highlight : Color.Empty;
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // preserve highlight color event when other component is selected
            e.Node.BackColor = SystemColors.Highlight;

            if (previous_node != null)
            {
                previous_node.BackColor = Color.Empty;
            }
            previous_node = e.Node;

            // the parent nodes (flash and ram) are fixed in their location
            if (e.Node.Parent == null)
            {
                enableComponents(false);
            }
            else
            {
                enableComponents(true);
            }

            // try to parse the node name
            // if it fails try to parse the parent name
            var nodeinfo = parseTreeName(e.Node.Text);
            if (!nodeinfo.HasValue)
            {
                var nodeinfo_new = parseTreeName(e.Node.Parent.Text);
                textBoxSectionName.Text = e.Node.Text;

                if (!nodeinfo_new.HasValue) return;

                updateOriginFromString(nodeinfo_new.Value.origin_s);
                updateSizeFromString(nodeinfo_new.Value.length_s);
                return;
            }

            // update text fields and numbers from parsed info
            textBoxSectionName.Text = nodeinfo.Value.name;
            updateOriginFromString(nodeinfo.Value.origin_s);
            updateSizeFromString(nodeinfo.Value.length_s);
        }

        private void buttonAddSection_Click(object sender, EventArgs e)
        {
            var new_node = treeView1.SelectedNode.Nodes.Add("undefined section");
            new_node.Parent.Expand();
            treeView1.SelectedNode = new_node;
        }

        private void buttonRemoveSection_Click(object sender, EventArgs e)
        {
            // do not remove root node
            if (treeView1.SelectedNode.Parent == null)
                return;

            treeView1.SelectedNode.Remove();
        }

        private void textBoxSectionOrigin_TextChanged(object sender, EventArgs e)
        {
            updateOriginFromString(textBoxSectionOrigin.Text);
        }

        private void textBoxSectionSize_TextChanged(object sender, EventArgs e)
        {
            updateSizeFromString(textBoxSectionSize.Text);
        }

        private void numericUpDownSectionSizeM_ValueChanged(object sender, EventArgs e)
        {
            updateSizeFromSpinbox();
        }

        private void numericUpDownSectionSizeL_ValueChanged(object sender, EventArgs e)
        {
            updateSizeFromSpinbox();
        }

        private void numericUpDownSectionOriginL_ValueChanged(object sender, EventArgs e)
        {
            updateOriginFromSpinbox();
        }

        private void numericUpDownSectionOriginM_ValueChanged(object sender, EventArgs e)
        {
            updateOriginFromSpinbox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // the spinboxes (numeric up down) always contain a correct value,
            //  so calculate the string version from them
            updateOriginFromSpinbox();
            updateSizeFromSpinbox();

            // update the text in the tree view
            var name = textBoxSectionName.Text;
            name += " - origin: " + textBoxSectionOrigin.Text;
            name += " - length: " + textBoxSectionSize.Text;
            name += " - end: " + textBoxSectionEnd.Text;

            treeView1.SelectedNode.Text = name;

            // validate input parameters and mark the incorrect sections red
            var parent_selected_section = treeView1.SelectedNode.Parent;
            if (parent_selected_section != null)
            {
                checkChildNodeSizes(parent_selected_section);
            }

            // generate linker code

            textBoxLinkerCode.Text = "MEMORY\r\n{\r\n";
            recursiveGenerateLinkerCode(treeView1.Nodes[0].Nodes, false);
            recursiveGenerateLinkerCode(treeView1.Nodes[1].Nodes, true);
            textBoxLinkerCode.Text += "}\r\n";
        }

        private void checkBoxSectionSizeSubtractBytes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSectionSizeSubtractBytes.Checked)
            {
                labelSectionSizeSign.Text = "-";
            }
            else
            {
                labelSectionSizeSign.Text = "+";
            }
            updateSizeFromSpinbox();
        }
    }
}
