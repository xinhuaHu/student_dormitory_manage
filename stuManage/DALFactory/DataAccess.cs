using System;
using System.Reflection;
using System.Configuration;
using stuManage.IDAL;
namespace stuManage.DALFactory
{
	public sealed class DataAccess//<t>
	{
        static readonly string AssemblyName = ConfigurationSettings.AppSettings["DalAssemblyName"];
		
		/// <summary>
		/// 创建Dormitory数据层接口。
		/// </summary>
		public static stuManage.IDAL.IDormitory CreateDormitory()
		{

            string ClassNamespace = AssemblyName + ".Dormitory";
            object objType = Assembly.Load(AssemblyName).CreateInstance(ClassNamespace);
			return (stuManage.IDAL.IDormitory)objType;
		}

		/// <summary>
		/// 创建Employee数据层接口。
		/// </summary>
		public static stuManage.IDAL.IEmployee CreateEmployee()
		{

            string ClassNamespace = AssemblyName + ".Employee";
            object objType = Assembly.Load(AssemblyName).CreateInstance(ClassNamespace);
			return (stuManage.IDAL.IEmployee)objType;
		}

		/// <summary>
		/// 创建Stustay数据层接口。
		/// </summary>
		public static stuManage.IDAL.IStustay CreateStustay()
		{

            string ClassNamespace = AssemblyName + ".Stustay";
            object objType = Assembly.Load(AssemblyName).CreateInstance(ClassNamespace);
			return (stuManage.IDAL.IStustay)objType;
		}

		/// <summary>
		/// 创建Utilities数据层接口。
		/// </summary>
		public static stuManage.IDAL.IUtilities CreateUtilities()
		{

            string ClassNamespace = AssemblyName + ".Utilities";
            object objType = Assembly.Load(AssemblyName).CreateInstance(ClassNamespace);
			return (stuManage.IDAL.IUtilities)objType;
		}
}
}