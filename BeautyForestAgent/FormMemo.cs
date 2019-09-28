using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BeautyForestAgent
{
    public partial class FormMemo : Form
    {
        public FormMemo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("건의사항이 보내졌습니다.", "건의사항 발송");
            this.Close();
        }

        private void btnLoadFileSelect_Click(object sender, EventArgs e)
        {  //파일 읽기 탭에서 '파일 선택' 클릭
            DialogResult result = this.loadFileDlg.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    this.txtLoadFile.Text = this.loadFileDlg.FileName;  //선택한 파일 위치 넣기
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("취소하셨습니다", "알림");
                    break;
            }

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        { //파일 읽기 탭에서 '불러오기' 클릭
            if (txtLoadFile.Text == "")
            {
                MessageBox.Show("읽을 파일을 선택해 주세요", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(txtLoadFile.Text))  //값이 존재하는지 확인
            {
                MessageBox.Show("읽을 파일이 없습니다", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (StreamReader sr = new StreamReader(this.txtLoadFile.Text))  //값 가져오는
            {  //using을 사용하면 해당 코드(StreamReader)가 끝날 때 자동으로 없어진다.
                this.txtLoadText.Text = sr.ReadToEnd();
            }

        }

        private void btnSaveFileSelect_Click(object sender, EventArgs e)
        {  //파일 쓰기 탭에서 '파일 선택' 클릭
            DialogResult result = this.saveFileDlg.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    this.txtSaveFile.Text = this.saveFileDlg.FileName;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("취소하셨습니다", "알림");
                    break;
            }

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {  //파일 쓰기 탭에서 '저장하기' 클릭
            if (txtSaveFile.Text == "")
            {
                MessageBox.Show("저장할 파일을 선택해 주세요", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(this.txtSaveFile.Text))
                {
                    sw.WriteLine(this.txtSaveText.Text);
                }
                MessageBox.Show("파일 저장 성공", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("파일 저장에 실패했습니다", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
