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
			/*convert string:int dict into string:string*/
			foreach (var item in data)
			{
				List<String> tmp = new List<string>{};
				foreach (var num in item.Value)
					tmp.Add(num.ToString());
				this.data[item.Key] = tmp.ToArray();
			}
			this.dataGridView = dataGridView;
			/*insert data in dict to datagridview*/
			foreach (var item in this.data)
			{
				List<String>tmp =new List<string> { item.Key };
				tmp.AddRange(new List<String>(item.Value));
				foreach(var str in tmp)
				{
					Console.Write(str + ' ');
				}
				Console.WriteLine();
				this.dataGridView.Rows.Add(tmp.ToArray());
			}
			generateRowNumber(this.dataGridView);
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

