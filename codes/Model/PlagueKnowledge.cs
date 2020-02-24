using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Model
{
    public class PlagueKnowledge
    {
        private RichTextBox plagueKnowledge;
        private Label title, type;
        private Button lBut, rBut;
        private List<String[]> data=new List<string[]>();
        public int index=0,lB=0,rB;
        public PlagueKnowledge(List<String[]> data,RichTextBox plagueKnowledge,Label title,Label type,
                                Button lBut,Button rBut)
        {
            this.plagueKnowledge= plagueKnowledge;
            this.data = data;
            this.title = title;this.type = type;
            this.lBut= lBut; this.rBut= rBut;
            this.rB = data.Count;
            show();
        }

        public bool validIndex(int newIndex)
        {
            return newIndex>=this.lB && newIndex<this.rB;
        }

        public void lBClicked()
        {
            if (validIndex(this.index - 1))
            {
                this.index--;
                show();
            }
        }

        public void rBClicked()
        {
            if (validIndex(this.index + 1))
            {
                this.index++;
                show();
            }
        }

        public void show()
        {
            String[] now = this.data[this.index];
            this.title.Text = now[0];
            this.type.Text = now[1];
            this.plagueKnowledge.Text = now[2];
            this.lBut.Enabled = (this.index != this.lB);
            this.rBut.Enabled = (this.index != this.rB - 1);
        }
    }
}
