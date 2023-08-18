namespace Monitoring.View
{
    partial class MultiLabel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBottomRight = new System.Windows.Forms.Label();
            this.lblBottomLeft = new System.Windows.Forms.Label();
            this.lblCenterRight = new System.Windows.Forms.Label();
            this.lblCenterLeft = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblBottomRight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBottomLeft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCenterRight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCenterLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(160, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBottomRight
            // 
            this.lblBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBottomRight.AutoSize = true;
            this.lblBottomRight.BackColor = System.Drawing.Color.White;
            this.lblBottomRight.Location = new System.Drawing.Point(80, 55);
            this.lblBottomRight.Margin = new System.Windows.Forms.Padding(0);
            this.lblBottomRight.Name = "lblBottomRight";
            this.lblBottomRight.Size = new System.Drawing.Size(79, 44);
            this.lblBottomRight.TabIndex = 4;
            this.lblBottomRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottomLeft
            // 
            this.lblBottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBottomLeft.AutoSize = true;
            this.lblBottomLeft.BackColor = System.Drawing.Color.White;
            this.lblBottomLeft.Location = new System.Drawing.Point(1, 55);
            this.lblBottomLeft.Margin = new System.Windows.Forms.Padding(0);
            this.lblBottomLeft.Name = "lblBottomLeft";
            this.lblBottomLeft.Size = new System.Drawing.Size(78, 44);
            this.lblBottomLeft.TabIndex = 3;
            this.lblBottomLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCenterRight
            // 
            this.lblCenterRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCenterRight.AutoSize = true;
            this.lblCenterRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCenterRight.Location = new System.Drawing.Point(80, 30);
            this.lblCenterRight.Margin = new System.Windows.Forms.Padding(0);
            this.lblCenterRight.Name = "lblCenterRight";
            this.lblCenterRight.Size = new System.Drawing.Size(79, 24);
            this.lblCenterRight.TabIndex = 2;
            this.lblCenterRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCenterLeft
            // 
            this.lblCenterLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCenterLeft.AutoSize = true;
            this.lblCenterLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCenterLeft.Location = new System.Drawing.Point(1, 30);
            this.lblCenterLeft.Margin = new System.Windows.Forms.Padding(0);
            this.lblCenterLeft.Name = "lblCenterLeft";
            this.lblCenterLeft.Size = new System.Drawing.Size(78, 24);
            this.lblCenterLeft.TabIndex = 1;
            this.lblCenterLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridBatStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "gridBatStatus";
            this.Size = new System.Drawing.Size(160, 100);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBottomLeft;
        private System.Windows.Forms.Label lblCenterRight;
        private System.Windows.Forms.Label lblCenterLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBottomRight;
    }
}
