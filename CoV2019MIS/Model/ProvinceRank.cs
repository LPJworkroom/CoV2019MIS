using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Model
{
    public class ProvinceRank
    {
		/*各省份累计数量*/
		private Dictionary<String,String[]> data=new Dictionary<string, string[]>();
		private DataGridView dataGridView=new DataGridView();
		public ProvinceRank(Dictionary<String, int[]> data, DataGridView dataGridView)
		{
			this.dataGridView = dataGridView;
			/*convert string:int dict into string:string*/
			foreach (var item in data)
				dataGridView.Rows.Add(item.Key, item.Value[0],item.Value[1], item.Value[2]);
			this.dataGridView.Sort(this.dataGridView.Columns[1], System.ComponentModel.ListSortDirection.Descending);
		}

		/*刷新排名顺序及控件*/
		public static void generateRowNumber(DataGridView dgv)
		{
			foreach (DataGridViewRow row in dgv.Rows)
			{
				row.HeaderCell.Value = (row.Index + 1).ToString();
			}
		}
		/*三个键的点击事件处理函数*/
		void keyClicked(int keyNo= 0) { }
	}
}

