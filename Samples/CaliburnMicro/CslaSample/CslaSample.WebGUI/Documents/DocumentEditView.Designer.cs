﻿namespace CslaSample.Documents
{
    partial class DocumentEditView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui UserControl Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentEditView));
            this.toolStrip1 = new Gizmox.WebGUI.Forms.ToolStrip();
            this.createNew = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.save = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.delete = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.close = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.model_DocumentId = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.model_DocumentReference = new Gizmox.WebGUI.Forms.TextBox();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.model_DocumentDate = new Gizmox.WebGUI.Forms.TextBox();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.model_Subject = new Gizmox.WebGUI.Forms.TextBox();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.model_Sender = new Gizmox.WebGUI.Forms.TextBox();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.model_Receiver = new Gizmox.WebGUI.Forms.TextBox();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.model_TextContent = new Gizmox.WebGUI.Forms.TextBox();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.model_CreateDate = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.model_ChangeDate = new Gizmox.WebGUI.Forms.Label();
            //this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.toolStrip1.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.createNew,
            this.save,
            this.delete,
            this.close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createNew
            // 
            this.createNew.DisplayStyle = Gizmox.WebGUI.Forms.ToolStripItemDisplayStyle.Image;
            this.createNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("createNew.Image"));
            this.createNew.Name = "createNew";
            this.createNew.Size = new System.Drawing.Size(23, 22);
            this.createNew.Text = "Create New";
            // 
            // save
            // 
            this.save.DisplayStyle = Gizmox.WebGUI.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("save.Image"));
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(23, 22);
            this.save.Text = "Save";
            // 
            // delete
            // 
            this.delete.DisplayStyle = Gizmox.WebGUI.Forms.ToolStripItemDisplayStyle.Image;
            this.delete.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("delete.Image"));
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(23, 22);
            this.delete.Text = "Delete";
            // 
            // close
            // 
            this.close.Alignment = Gizmox.WebGUI.Forms.ToolStripItemAlignment.Right;
            this.close.DisplayStyle = Gizmox.WebGUI.Forms.ToolStripItemDisplayStyle.Image;
            this.close.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("close.Image"));
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 22);
            this.close.Text = "Close form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Document Id";
            // 
            // model_DocumentId
            // 
            this.model_DocumentId.AutoSize = true;
            this.model_DocumentId.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.model_DocumentId.Location = new System.Drawing.Point(119, 50);
            this.model_DocumentId.Name = "model_DocumentId";
            this.model_DocumentId.Size = new System.Drawing.Size(0, 13);
            this.model_DocumentId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reference";
            // 
            // model_DocumentReference
            // 
            this.model_DocumentReference.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.model_DocumentReference.Location = new System.Drawing.Point(116, 77);
            this.model_DocumentReference.Name = "model_DocumentReference";
            this.model_DocumentReference.Size = new System.Drawing.Size(234, 20);
            this.model_DocumentReference.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label3.Location = new System.Drawing.Point(568, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // model_DocumentDate
            // 
            this.model_DocumentDate.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.model_DocumentDate.Location = new System.Drawing.Point(615, 77);
            this.model_DocumentDate.Name = "model_DocumentDate";
            this.model_DocumentDate.Size = new System.Drawing.Size(92, 20);
            this.model_DocumentDate.TabIndex = 6;
            this.model_DocumentDate.WinFormsCompatibility.TextBoxRealTimeKeyboardEvents = Gizmox.WebGUI.Forms.WinFormsCompatibilityStates.False;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subject";
            // 
            // model_Subject
            // 
            this.model_Subject.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.model_Subject.Location = new System.Drawing.Point(116, 107);
            this.model_Subject.Name = "model_Subject";
            this.model_Subject.Size = new System.Drawing.Size(591, 20);
            this.model_Subject.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sender";
            // 
            // model_Sender
            // 
            this.model_Sender.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.model_Sender.Location = new System.Drawing.Point(116, 137);
            this.model_Sender.Name = "model_Sender";
            this.model_Sender.Size = new System.Drawing.Size(334, 20);
            this.model_Sender.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label6.Location = new System.Drawing.Point(15, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Receiver";
            // 
            // model_Receiver
            // 
            this.model_Receiver.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.model_Receiver.Location = new System.Drawing.Point(116, 167);
            this.model_Receiver.Name = "model_Receiver";
            this.model_Receiver.Size = new System.Drawing.Size(334, 20);
            this.model_Receiver.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label7.Location = new System.Drawing.Point(15, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Text Content";
            // 
            // model_TextContent
            // 
            this.model_TextContent.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.model_TextContent.Location = new System.Drawing.Point(116, 197);
            this.model_TextContent.Multiline = true;
            this.model_TextContent.Name = "model_TextContent";
            this.model_TextContent.Size = new System.Drawing.Size(591, 243);
            this.model_TextContent.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label8.Location = new System.Drawing.Point(15, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Created Date";
            // 
            // model_CreateDate
            // 
            this.model_CreateDate.AutoSize = true;
            this.model_CreateDate.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.model_CreateDate.Location = new System.Drawing.Point(119, 460);
            this.model_CreateDate.Name = "model_CreateDate";
            this.model_CreateDate.Size = new System.Drawing.Size(0, 13);
            this.model_CreateDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label9.Location = new System.Drawing.Point(15, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Changed Date";
            // 
            // model_ChangeDate
            // 
            this.model_ChangeDate.AutoSize = true;
            this.model_ChangeDate.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.model_ChangeDate.Location = new System.Drawing.Point(119, 490);
            this.model_ChangeDate.Name = "model_ChangeDate";
            this.model_ChangeDate.Size = new System.Drawing.Size(0, 13);
            this.model_ChangeDate.TabIndex = 18;
            // 
            // DocumentEditView
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = Gizmox.WebGUI.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.model_ChangeDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.model_CreateDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.model_TextContent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.model_Receiver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.model_Sender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.model_Subject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.model_DocumentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.model_DocumentReference);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.model_DocumentId);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            //this.Name = "DocumentEditView";
            this.Size = new System.Drawing.Size(752, 523);
            //this.toolStrip1.ResumeLayout(false);
            //this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            //this.PerformLayout();

        }

        #endregion

        private Gizmox.WebGUI.Forms.ToolStrip toolStrip1;
        private Gizmox.WebGUI.Forms.ToolStripButton createNew;
        private Gizmox.WebGUI.Forms.ToolStripButton save;
        private Gizmox.WebGUI.Forms.ToolStripButton delete;
        private Gizmox.WebGUI.Forms.ToolStripButton close;
        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.Label model_DocumentId;
        private Gizmox.WebGUI.Forms.Label label2;
        private Gizmox.WebGUI.Forms.TextBox model_DocumentReference;
        private Gizmox.WebGUI.Forms.Label label3;
        private Gizmox.WebGUI.Forms.TextBox model_DocumentDate;
        private Gizmox.WebGUI.Forms.Label label4;
        private Gizmox.WebGUI.Forms.TextBox model_Subject;
        private Gizmox.WebGUI.Forms.Label label5;
        private Gizmox.WebGUI.Forms.TextBox model_Sender;
        private Gizmox.WebGUI.Forms.Label label6;
        private Gizmox.WebGUI.Forms.TextBox model_Receiver;
        private Gizmox.WebGUI.Forms.Label label7;
        private Gizmox.WebGUI.Forms.TextBox model_TextContent;
        private Gizmox.WebGUI.Forms.Label label8;
        private Gizmox.WebGUI.Forms.Label model_CreateDate;
        private Gizmox.WebGUI.Forms.Label label9;
        private Gizmox.WebGUI.Forms.Label model_ChangeDate;
    }
}
