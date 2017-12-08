/**  版本信息模板在安装目录下，可自行修改。
* Employee.cs
*
* 功 能： N/A
* 类 名： Employee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-12-08 15:10:26   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
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
		private int? _emp_age;
		private string _flo_num;
		private string _emp_sex;
		private string _position;
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
		public int? emp_age
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
		public string position
		{
			set{ _position=value;}
			get{return _position;}
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

