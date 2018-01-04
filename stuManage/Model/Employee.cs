using System;
namespace stuManage.Model
{
	/// <summary>
	/// Employee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Employee
	{
		public Employee()
		{}
		#region Model
		private string _emp_num;
		private string _emp_name;
		private string _emp_passwd;
		private string _emp_age;
		private string _flo_num;
		private string _emp_sex;
		private string _con_infor;
		/// <summary>
		/// 
		/// </summary>
		public string emp_num
		{
			set{ _emp_num=value;}
			get{return _emp_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string emp_name
		{
			set{ _emp_name=value;}
			get{return _emp_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string emp_passwd
		{
			set{ _emp_passwd=value;}
			get{return _emp_passwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string emp_age
		{
			set{ _emp_age=value;}
			get{return _emp_age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string flo_num
		{
			set{ _flo_num=value;}
			get{return _flo_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string emp_sex
		{
			set{ _emp_sex=value;}
			get{return _emp_sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string con_infor
		{
			set{ _con_infor=value;}
			get{return _con_infor;}
		}
		#endregion Model

	}
}

