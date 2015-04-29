using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace PatSI
{
    public partial class NewZT : Form
    {
        public NewZT()
        {
            InitializeComponent();
            //this.errorProvider1.SetIconAlignment(this.txtName, ErrorIconAlignment.MiddleLeft);
            //this.errorProvider1.SetIconAlignment(this.txtDesc, ErrorIconAlignment.BottomLeft);
        }
        public string id;
        public string ztname;
        public string type;
        public string sucess_message = "添加";
        public NewZT(string id, string name, string des, string type)
        {
            InitializeComponent();
            if (type == "") type = "CPRS";
            this.ztname = name;
            this.id = id;
            this.txtName.Text = name;
            this.txtDesc.Text = des;
            this.type = type.ToUpper();
            this.Text = "修改专题库";
            this.btnSubMit.Text = "修改";
            this.sucess_message = "修改";
            
            foreach (var x in this.Controls)
            {
                if (x.GetType() == typeof(RadioButton))
                {
                    var rb = x as RadioButton;
                    if (rb.Text == this.type)
                    {
                        rb.Checked = true;
                    }
                    else
                    {
                        rb.Enabled = false;
                    }
                }
            }
        }

        private void btnSubMit_Click(object sender, EventArgs e)
        {
            bool haserror = false;

            if (this.txtName.Text.Trim() == "")
            {
                haserror = true;
                this.errorProvider1.SetError(this.txtName, "专题库名称不能为空");

            }
            if (this.txtDesc.Text.Trim() == "")
            {
                haserror = true;
                this.errorProvider1.SetError(this.txtDesc, "专题库描述不能为空");

            }
            if (haserror)
            {
                return;
            }
            if ((this.Text == "修改专题库" && this.ztname != this.txtName.Text.Trim()) || this.Text == "新建专题库")
            {
                if (ZTHelper.ExistZTDB(this.txtName.Text.Trim()))
                {
                    haserror = true;
                    this.errorProvider1.SetError(this.txtName, "专题库名称已经存在");
                    MessageBox.Show("专题库名称已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (haserror)
            {
                return;
            }
            this.errorProvider1.Clear();
            bool res;
            string type = "";
            foreach (var x in this.Controls)
            {
                if (x.GetType() == typeof(RadioButton))
                {
                    var rb = x as RadioButton;
                    if (rb.Checked == true)
                    {
                        type = rb.Text;
                    }
                }
            }
            if (this.Text == "修改专题库")
            {
                res = ZTHelper.EditZTDB(id, this.txtName.Text.Trim(), this.txtDesc.Text.Trim(),type);
            }
            else
            {
                res = ZTHelper.AddZTDB(this.txtName.Text.Trim(), this.txtDesc.Text.Trim(), type);
            }
            if (res)
            {
                MessageBox.Show(sucess_message + "成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtDesc.Text = "";
                this.txtName.Text = "";
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show(sucess_message + "失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (this.txtName.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtName, "专题库名称不能为空");
                return;
            }
            if ((this.Text == "修改专题库" && this.ztname != this.txtName.Text.Trim()) || this.Text == "新建专题库")
            {
                if (ZTHelper.ExistZTDB(this.txtName.Text.Trim()))
                {
                    this.errorProvider1.SetError(this.txtName, "专题库名称已经存在");
                    MessageBox.Show("专题库名称已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }

        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            if (this.txtDesc.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtDesc, "专题库描述不能为空");

            }
        }
    }
}
