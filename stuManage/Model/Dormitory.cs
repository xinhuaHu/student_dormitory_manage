using System;
namespace stuManage.Model
{
	/// <summary>
	/// Dormitory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Dormitory
	{
		public Dormitory()
		{}
		#region Model
		private string _number;
		private string _flo_num;
		private string _dor_num;
		private string _num_occupants;
		private string _live_num;
		/// <summary>
		/// 
		/// </summary>
		public string number
		{
			set{ _number=value;}
			get{return _number;}
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
		public string dor_num
		{
			set{ _dor_num=value;}
			get{return _dor_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string num_occupants
		{
			set{ _num_occupants=value;}
			get{return _num_occupants;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string live_num
		{
			set{ _live_num=value;}
			get{return _live_num;}
		}
		#endregion Model

	}
}

