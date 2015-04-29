#region Auto-generated classes for ztst database on 2015-04-26 17:40:49Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from ztst on 2015-04-26 17:40:49Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Reflection;
using DbLinq.Data.Linq;
using DbLinq.Vendor;
using System.ComponentModel;

namespace DAL
{
	public partial class ZTST : DataContext
	{
		public ZTST(IDbConnection connection)
		: base(connection, new DbLinq.MySql.MySqlVendor())
		{
		}

		public ZTST(IDbConnection connection, IVendor vendor)
		: base(connection, vendor)
		{
		}

		public Table<CfGCountry> CfGCountry { get { return GetTable<CfGCountry>(); } }
		public Table<CfGDiZHi> CfGDiZHi { get { return GetTable<CfGDiZHi>(); } }
		public Table<CfGEPO> CfGEPO { get { return GetTable<CfGEPO>(); } }
		public Table<CfGPa> CfGPa { get { return GetTable<CfGPa>(); } }
		public Table<CfGQUYU> CfGQUYU { get { return GetTable<CfGQUYU>(); } }
		public Table<CfGSTColumn> CfGSTColumn { get { return GetTable<CfGSTColumn>(); } }
		public Table<CfGTemplate> CfGTemplate { get { return GetTable<CfGTemplate>(); } }
		public Table<ChartColumn> ChartColumn { get { return GetTable<ChartColumn>(); } }
		public Table<ChartGroup> ChartGroup { get { return GetTable<ChartGroup>(); } }
		public Table<ChartItems> ChartItems { get { return GetTable<ChartItems>(); } }
		public Table<ChartType> ChartType { get { return GetTable<ChartType>(); } }
		public Table<ChartZHIbiAO> ChartZHIbiAO { get { return GetTable<ChartZHIbiAO>(); } }
		public Table<IDXKey> IDXKey { get { return GetTable<IDXKey>(); } }
		public Table<IDXKeyVAL> IDXKeyVAL { get { return GetTable<IDXKeyVAL>(); } }
		public Table<IDXVAL> IDXVAL { get { return GetTable<IDXVAL>(); } }
		public Table<ShowBase> ShowBase { get { return GetTable<ShowBase>(); } }
		public Table<STAnS> STAnS { get { return GetTable<STAnS>(); } }
		public Table<STCPc> STCPc { get { return GetTable<STCPc>(); } }
		public Table<STCt> STCt { get { return GetTable<STCt>(); } }
		public Table<STDMc> STDMc { get { return GetTable<STDMc>(); } }
		public Table<STDT> STDT { get { return GetTable<STDT>(); } }
		public Table<STEc> STEc { get { return GetTable<STEc>(); } }
		public Table<STFML> STFML { get { return GetTable<STFML>(); } }
		public Table<STIpc> STIpc { get { return GetTable<STIpc>(); } }
		public Table<STIV> STIV { get { return GetTable<STIV>(); } }
		public Table<STPa> STPa { get { return GetTable<STPa>(); } }
		public Table<STPNS> STPNS { get { return GetTable<STPNS>(); } }
		public Table<STPR> STPR { get { return GetTable<STPR>(); } }
		public Table<STZTList> STZTList { get { return GetTable<STZTList>(); } }

	}

	[Table(Name = "ztst.cfg_country")]
	public partial class CfGCountry : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string DAimA

		private string _daImA;
		[DebuggerNonUserCode]
		[Column(Storage = "_daImA", Name = "daima", DbType = "varchar(2)")]
		public string DAimA
		{
			get
			{
				return _daImA;
			}
			set
			{
				if (value != _daImA)
				{
					_daImA = value;
					OnPropertyChanged("DAimA");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string MInGCheng

		private string _miNGcHeng;
		[DebuggerNonUserCode]
		[Column(Storage = "_miNGcHeng", Name = "mingcheng", DbType = "varchar(40)")]
		public string MInGCheng
		{
			get
			{
				return _miNGcHeng;
			}
			set
			{
				if (value != _miNGcHeng)
				{
					_miNGcHeng = value;
					OnPropertyChanged("MInGCheng");
				}
			}
		}

		#endregion

		#region sbyte? Type

		private sbyte? _type;
		[DebuggerNonUserCode]
		[Column(Storage = "_type", Name = "type", DbType = "tinyint(4)")]
		public sbyte? Type
		{
			get
			{
				return _type;
			}
			set
			{
				if (value != _type)
				{
					_type = value;
					OnPropertyChanged("Type");
				}
			}
		}

		#endregion

		#region ctor

		public CfGCountry()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.cfg_dizhi")]
	public partial class CfGDiZHi : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string DiZHi

		private string _diZhI;
		[DebuggerNonUserCode]
		[Column(Storage = "_diZhI", Name = "dizhi", DbType = "varchar(255)")]
		public string DiZHi
		{
			get
			{
				return _diZhI;
			}
			set
			{
				if (value != _diZhI)
				{
					_diZhI = value;
					OnPropertyChanged("DiZHi");
				}
			}
		}

		#endregion

		#region string GJ

		private string _gj;
		[DebuggerNonUserCode]
		[Column(Storage = "_gj", Name = "gj", DbType = "varchar(20)")]
		public string GJ
		{
			get
			{
				return _gj;
			}
			set
			{
				if (value != _gj)
				{
					_gj = value;
					OnPropertyChanged("GJ");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string QUXian

		private string _quxIan;
		[DebuggerNonUserCode]
		[Column(Storage = "_quxIan", Name = "quxian", DbType = "varchar(20)")]
		public string QUXian
		{
			get
			{
				return _quxIan;
			}
			set
			{
				if (value != _quxIan)
				{
					_quxIan = value;
					OnPropertyChanged("QUXian");
				}
			}
		}

		#endregion

		#region string ShEng

		private string _shEng;
		[DebuggerNonUserCode]
		[Column(Storage = "_shEng", Name = "sheng", DbType = "varchar(20)")]
		public string ShEng
		{
			get
			{
				return _shEng;
			}
			set
			{
				if (value != _shEng)
				{
					_shEng = value;
					OnPropertyChanged("ShEng");
				}
			}
		}

		#endregion

		#region string ShI

		private string _shI;
		[DebuggerNonUserCode]
		[Column(Storage = "_shI", Name = "shi", DbType = "varchar(20)")]
		public string ShI
		{
			get
			{
				return _shI;
			}
			set
			{
				if (value != _shI)
				{
					_shI = value;
					OnPropertyChanged("ShI");
				}
			}
		}

		#endregion

		#region ctor

		public CfGDiZHi()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.cfg_epo")]
	public partial class CfGEPO : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string GJ

		private string _gj;
		[DebuggerNonUserCode]
		[Column(Storage = "_gj", Name = "gj", DbType = "varchar(20)")]
		public string GJ
		{
			get
			{
				return _gj;
			}
			set
			{
				if (value != _gj)
				{
					_gj = value;
					OnPropertyChanged("GJ");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region ctor

		public CfGEPO()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.cfg_pa")]
	public partial class CfGPa : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string PaNewName

		private string _paNewName;
		[DebuggerNonUserCode]
		[Column(Storage = "_paNewName", Name = "pa_new_name", DbType = "varchar(200)")]
		public string PaNewName
		{
			get
			{
				return _paNewName;
			}
			set
			{
				if (value != _paNewName)
				{
					_paNewName = value;
					OnPropertyChanged("PaNewName");
				}
			}
		}

		#endregion

		#region string PaOldName

		private string _paOldName;
		[DebuggerNonUserCode]
		[Column(Storage = "_paOldName", Name = "pa_old_name", DbType = "varchar(200)")]
		public string PaOldName
		{
			get
			{
				return _paOldName;
			}
			set
			{
				if (value != _paOldName)
				{
					_paOldName = value;
					OnPropertyChanged("PaOldName");
				}
			}
		}

		#endregion

		#region ctor

		public CfGPa()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.cfg_quyu")]
	public partial class CfGQUYU : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string GJ

		private string _gj;
		[DebuggerNonUserCode]
		[Column(Storage = "_gj", Name = "gj", DbType = "varchar(20)")]
		public string GJ
		{
			get
			{
				return _gj;
			}
			set
			{
				if (value != _gj)
				{
					_gj = value;
					OnPropertyChanged("GJ");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string QUXian

		private string _quxIan;
		[DebuggerNonUserCode]
		[Column(Storage = "_quxIan", Name = "quxian", DbType = "varchar(20)")]
		public string QUXian
		{
			get
			{
				return _quxIan;
			}
			set
			{
				if (value != _quxIan)
				{
					_quxIan = value;
					OnPropertyChanged("QUXian");
				}
			}
		}

		#endregion

		#region string QUYU

		private string _quyu;
		[DebuggerNonUserCode]
		[Column(Storage = "_quyu", Name = "quyu", DbType = "varchar(30)")]
		public string QUYU
		{
			get
			{
				return _quyu;
			}
			set
			{
				if (value != _quyu)
				{
					_quyu = value;
					OnPropertyChanged("QUYU");
				}
			}
		}

		#endregion

		#region string ShEng

		private string _shEng;
		[DebuggerNonUserCode]
		[Column(Storage = "_shEng", Name = "sheng", DbType = "varchar(20)")]
		public string ShEng
		{
			get
			{
				return _shEng;
			}
			set
			{
				if (value != _shEng)
				{
					_shEng = value;
					OnPropertyChanged("ShEng");
				}
			}
		}

		#endregion

		#region ctor

		public CfGQUYU()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.cfg_stcolumn")]
	public partial class CfGSTColumn : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string ColName

		private string _colName;
		[DebuggerNonUserCode]
		[Column(Storage = "_colName", Name = "col_name", DbType = "varchar(20)")]
		public string ColName
		{
			get
			{
				return _colName;
			}
			set
			{
				if (value != _colName)
				{
					_colName = value;
					OnPropertyChanged("ColName");
				}
			}
		}

		#endregion

		#region string DbType

		private string _dbType;
		[DebuggerNonUserCode]
		[Column(Storage = "_dbType", Name = "db_type", DbType = "varchar(20)")]
		public string DbType
		{
			get
			{
				return _dbType;
			}
			set
			{
				if (value != _dbType)
				{
					_dbType = value;
					OnPropertyChanged("DbType");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region sbyte? IsAutoIDX

		private sbyte? _isAutoIdx;
		[DebuggerNonUserCode]
		[Column(Storage = "_isAutoIdx", Name = "isautoidx", DbType = "tinyint(4)")]
		public sbyte? IsAutoIDX
		{
			get
			{
				return _isAutoIdx;
			}
			set
			{
				if (value != _isAutoIdx)
				{
					_isAutoIdx = value;
					OnPropertyChanged("IsAutoIDX");
				}
			}
		}

		#endregion

		#region sbyte? IsCN

		private sbyte? _isCn;
		[DebuggerNonUserCode]
		[Column(Storage = "_isCn", Name = "iscn", DbType = "tinyint(4)")]
		public sbyte? IsCN
		{
			get
			{
				return _isCn;
			}
			set
			{
				if (value != _isCn)
				{
					_isCn = value;
					OnPropertyChanged("IsCN");
				}
			}
		}

		#endregion

		#region sbyte? IsDel

		private sbyte? _isDel;
		[DebuggerNonUserCode]
		[Column(Storage = "_isDel", Name = "isdel", DbType = "tinyint(4)")]
		public sbyte? IsDel
		{
			get
			{
				return _isDel;
			}
			set
			{
				if (value != _isDel)
				{
					_isDel = value;
					OnPropertyChanged("IsDel");
				}
			}
		}

		#endregion

		#region sbyte? IsEPodOC

		private sbyte? _isEpOdOc;
		[DebuggerNonUserCode]
		[Column(Storage = "_isEpOdOc", Name = "isepodoc", DbType = "tinyint(4)")]
		public sbyte? IsEPodOC
		{
			get
			{
				return _isEpOdOc;
			}
			set
			{
				if (value != _isEpOdOc)
				{
					_isEpOdOc = value;
					OnPropertyChanged("IsEPodOC");
				}
			}
		}

		#endregion

		#region sbyte? IsiDX

		private sbyte? _isiDx;
		[DebuggerNonUserCode]
		[Column(Storage = "_isiDx", Name = "isidx", DbType = "tinyint(4)")]
		public sbyte? IsiDX
		{
			get
			{
				return _isiDx;
			}
			set
			{
				if (value != _isiDx)
				{
					_isiDx = value;
					OnPropertyChanged("IsiDX");
				}
			}
		}

		#endregion

		#region sbyte? ISst

		private sbyte? _isSt;
		[DebuggerNonUserCode]
		[Column(Storage = "_isSt", Name = "isst", DbType = "tinyint(4)")]
		public sbyte? ISst
		{
			get
			{
				return _isSt;
			}
			set
			{
				if (value != _isSt)
				{
					_isSt = value;
					OnPropertyChanged("ISst");
				}
			}
		}

		#endregion

		#region sbyte? IsWpi

		private sbyte? _isWpi;
		[DebuggerNonUserCode]
		[Column(Storage = "_isWpi", Name = "iswpi", DbType = "tinyint(4)")]
		public sbyte? IsWpi
		{
			get
			{
				return _isWpi;
			}
			set
			{
				if (value != _isWpi)
				{
					_isWpi = value;
					OnPropertyChanged("IsWpi");
				}
			}
		}

		#endregion

		#region string ShownAme

		private string _shownAme;
		[DebuggerNonUserCode]
		[Column(Storage = "_shownAme", Name = "showname", DbType = "varchar(20)")]
		public string ShownAme
		{
			get
			{
				return _shownAme;
			}
			set
			{
				if (value != _shownAme)
				{
					_shownAme = value;
					OnPropertyChanged("ShownAme");
				}
			}
		}

		#endregion

		#region string TabName

		private string _tabName;
		[DebuggerNonUserCode]
		[Column(Storage = "_tabName", Name = "tab_name", DbType = "varchar(20)")]
		public string TabName
		{
			get
			{
				return _tabName;
			}
			set
			{
				if (value != _tabName)
				{
					_tabName = value;
					OnPropertyChanged("TabName");
				}
			}
		}

		#endregion

		#region ctor

		public CfGSTColumn()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.cfg_template")]
	public partial class CfGTemplate : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string DbType

		private string _dbType;
		[DebuggerNonUserCode]
		[Column(Storage = "_dbType", Name = "dbtype", DbType = "varchar(20)")]
		public string DbType
		{
			get
			{
				return _dbType;
			}
			set
			{
				if (value != _dbType)
				{
					_dbType = value;
					OnPropertyChanged("DbType");
				}
			}
		}

		#endregion

		#region string FileType

		private string _fileType;
		[DebuggerNonUserCode]
		[Column(Storage = "_fileType", Name = "filetype", DbType = "varchar(20)")]
		public string FileType
		{
			get
			{
				return _fileType;
			}
			set
			{
				if (value != _fileType)
				{
					_fileType = value;
					OnPropertyChanged("FileType");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string Name

		private string _name;
		[DebuggerNonUserCode]
		[Column(Storage = "_name", Name = "name", DbType = "varchar(255)")]
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value != _name)
				{
					_name = value;
					OnPropertyChanged("Name");
				}
			}
		}

		#endregion

		#region string Path

		private string _path;
		[DebuggerNonUserCode]
		[Column(Storage = "_path", Name = "path", DbType = "varchar(500)")]
		public string Path
		{
			get
			{
				return _path;
			}
			set
			{
				if (value != _path)
				{
					_path = value;
					OnPropertyChanged("Path");
				}
			}
		}

		#endregion

		#region ctor

		public CfGTemplate()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.chart_column")]
	public partial class ChartColumn : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region sbyte? CN

		private sbyte? _cn;
		[DebuggerNonUserCode]
		[Column(Storage = "_cn", Name = "cn", DbType = "tinyint(1)")]
		public sbyte? CN
		{
			get
			{
				return _cn;
			}
			set
			{
				if (value != _cn)
				{
					_cn = value;
					OnPropertyChanged("CN");
				}
			}
		}

		#endregion

		#region string ColName

		private string _colName;
		[DebuggerNonUserCode]
		[Column(Storage = "_colName", Name = "colname", DbType = "varchar(255)")]
		public string ColName
		{
			get
			{
				return _colName;
			}
			set
			{
				if (value != _colName)
				{
					_colName = value;
					OnPropertyChanged("ColName");
				}
			}
		}

		#endregion

		#region sbyte? EPodOC

		private sbyte? _epOdOc;
		[DebuggerNonUserCode]
		[Column(Storage = "_epOdOc", Name = "epodoc", DbType = "tinyint(1)")]
		public sbyte? EPodOC
		{
			get
			{
				return _epOdOc;
			}
			set
			{
				if (value != _epOdOc)
				{
					_epOdOc = value;
					OnPropertyChanged("EPodOC");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string ItemName

		private string _itemName;
		[DebuggerNonUserCode]
		[Column(Storage = "_itemName", Name = "item_name", DbType = "varchar(255)")]
		public string ItemName
		{
			get
			{
				return _itemName;
			}
			set
			{
				if (value != _itemName)
				{
					_itemName = value;
					OnPropertyChanged("ItemName");
				}
			}
		}

		#endregion

		#region string ShowName

		private string _showName;
		[DebuggerNonUserCode]
		[Column(Storage = "_showName", Name = "show_name", DbType = "varchar(255)")]
		public string ShowName
		{
			get
			{
				return _showName;
			}
			set
			{
				if (value != _showName)
				{
					_showName = value;
					OnPropertyChanged("ShowName");
				}
			}
		}

		#endregion

		#region string TableName

		private string _tableName;
		[DebuggerNonUserCode]
		[Column(Storage = "_tableName", Name = "table_name", DbType = "varchar(255)")]
		public string TableName
		{
			get
			{
				return _tableName;
			}
			set
			{
				if (value != _tableName)
				{
					_tableName = value;
					OnPropertyChanged("TableName");
				}
			}
		}

		#endregion

		#region sbyte? Wpi

		private sbyte? _wpi;
		[DebuggerNonUserCode]
		[Column(Storage = "_wpi", Name = "wpi", DbType = "tinyint(1)")]
		public sbyte? Wpi
		{
			get
			{
				return _wpi;
			}
			set
			{
				if (value != _wpi)
				{
					_wpi = value;
					OnPropertyChanged("Wpi");
				}
			}
		}

		#endregion

		#region ctor

		public ChartColumn()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.chart_group")]
	public partial class ChartGroup : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string ChartGroup1

		private string _chartGroup1;
		[DebuggerNonUserCode]
		[Column(Storage = "_chartGroup1", Name = "chart_group", DbType = "varchar(255)")]
		public string ChartGroup1
		{
			get
			{
				return _chartGroup1;
			}
			set
			{
				if (value != _chartGroup1)
				{
					_chartGroup1 = value;
					OnPropertyChanged("ChartGroup1");
				}
			}
		}

		#endregion

		#region sbyte? CN

		private sbyte? _cn;
		[DebuggerNonUserCode]
		[Column(Storage = "_cn", Name = "cn", DbType = "tinyint(1)")]
		public sbyte? CN
		{
			get
			{
				return _cn;
			}
			set
			{
				if (value != _cn)
				{
					_cn = value;
					OnPropertyChanged("CN");
				}
			}
		}

		#endregion

		#region sbyte? EPodOC

		private sbyte? _epOdOc;
		[DebuggerNonUserCode]
		[Column(Storage = "_epOdOc", Name = "epodoc", DbType = "tinyint(1)")]
		public sbyte? EPodOC
		{
			get
			{
				return _epOdOc;
			}
			set
			{
				if (value != _epOdOc)
				{
					_epOdOc = value;
					OnPropertyChanged("EPodOC");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region sbyte? Wpi

		private sbyte? _wpi;
		[DebuggerNonUserCode]
		[Column(Storage = "_wpi", Name = "wpi", DbType = "tinyint(1)")]
		public sbyte? Wpi
		{
			get
			{
				return _wpi;
			}
			set
			{
				if (value != _wpi)
				{
					_wpi = value;
					OnPropertyChanged("Wpi");
				}
			}
		}

		#endregion

		#region ctor

		public ChartGroup()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.chart_items")]
	public partial class ChartItems : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string ChartGroup

		private string _chartGroup;
		[DebuggerNonUserCode]
		[Column(Storage = "_chartGroup", Name = "chart_group", DbType = "varchar(255)")]
		public string ChartGroup
		{
			get
			{
				return _chartGroup;
			}
			set
			{
				if (value != _chartGroup)
				{
					_chartGroup = value;
					OnPropertyChanged("ChartGroup");
				}
			}
		}

		#endregion

		#region sbyte? CN

		private sbyte? _cn;
		[DebuggerNonUserCode]
		[Column(Storage = "_cn", Name = "cn", DbType = "tinyint(1)")]
		public sbyte? CN
		{
			get
			{
				return _cn;
			}
			set
			{
				if (value != _cn)
				{
					_cn = value;
					OnPropertyChanged("CN");
				}
			}
		}

		#endregion

		#region sbyte? EPodOC

		private sbyte? _epOdOc;
		[DebuggerNonUserCode]
		[Column(Storage = "_epOdOc", Name = "epodoc", DbType = "tinyint(1)")]
		public sbyte? EPodOC
		{
			get
			{
				return _epOdOc;
			}
			set
			{
				if (value != _epOdOc)
				{
					_epOdOc = value;
					OnPropertyChanged("EPodOC");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string ItemDesC

		private string _itemDesC;
		[DebuggerNonUserCode]
		[Column(Storage = "_itemDesC", Name = "item_desc", DbType = "varchar(255)")]
		public string ItemDesC
		{
			get
			{
				return _itemDesC;
			}
			set
			{
				if (value != _itemDesC)
				{
					_itemDesC = value;
					OnPropertyChanged("ItemDesC");
				}
			}
		}

		#endregion

		#region string ItemName

		private string _itemName;
		[DebuggerNonUserCode]
		[Column(Storage = "_itemName", Name = "item_name", DbType = "varchar(255)")]
		public string ItemName
		{
			get
			{
				return _itemName;
			}
			set
			{
				if (value != _itemName)
				{
					_itemName = value;
					OnPropertyChanged("ItemName");
				}
			}
		}

		#endregion

		#region sbyte? Wpi

		private sbyte? _wpi;
		[DebuggerNonUserCode]
		[Column(Storage = "_wpi", Name = "wpi", DbType = "tinyint(1)")]
		public sbyte? Wpi
		{
			get
			{
				return _wpi;
			}
			set
			{
				if (value != _wpi)
				{
					_wpi = value;
					OnPropertyChanged("Wpi");
				}
			}
		}

		#endregion

		#region ctor

		public ChartItems()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.chart_type")]
	public partial class ChartType : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string CharType

		private string _charType;
		[DebuggerNonUserCode]
		[Column(Storage = "_charType", Name = "char_type", DbType = "varchar(255)")]
		public string CharType
		{
			get
			{
				return _charType;
			}
			set
			{
				if (value != _charType)
				{
					_charType = value;
					OnPropertyChanged("CharType");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string ItemName

		private string _itemName;
		[DebuggerNonUserCode]
		[Column(Storage = "_itemName", Name = "item_name", DbType = "varchar(255)")]
		public string ItemName
		{
			get
			{
				return _itemName;
			}
			set
			{
				if (value != _itemName)
				{
					_itemName = value;
					OnPropertyChanged("ItemName");
				}
			}
		}

		#endregion

		#region string ShowName

		private string _showName;
		[DebuggerNonUserCode]
		[Column(Storage = "_showName", Name = "show_name", DbType = "varchar(255)")]
		public string ShowName
		{
			get
			{
				return _showName;
			}
			set
			{
				if (value != _showName)
				{
					_showName = value;
					OnPropertyChanged("ShowName");
				}
			}
		}

		#endregion

		#region ctor

		public ChartType()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.chart_zhibiao")]
	public partial class ChartZHIbiAO : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region sbyte? CN

		private sbyte? _cn;
		[DebuggerNonUserCode]
		[Column(Storage = "_cn", Name = "cn", DbType = "tinyint(1)")]
		public sbyte? CN
		{
			get
			{
				return _cn;
			}
			set
			{
				if (value != _cn)
				{
					_cn = value;
					OnPropertyChanged("CN");
				}
			}
		}

		#endregion

		#region sbyte? EPodOC

		private sbyte? _epOdOc;
		[DebuggerNonUserCode]
		[Column(Storage = "_epOdOc", Name = "epodoc", DbType = "tinyint(1)")]
		public sbyte? EPodOC
		{
			get
			{
				return _epOdOc;
			}
			set
			{
				if (value != _epOdOc)
				{
					_epOdOc = value;
					OnPropertyChanged("EPodOC");
				}
			}
		}

		#endregion

		#region string FunCType

		private string _funCtYpe;
		[DebuggerNonUserCode]
		[Column(Storage = "_funCtYpe", Name = "func_type", DbType = "varchar(50)")]
		public string FunCType
		{
			get
			{
				return _funCtYpe;
			}
			set
			{
				if (value != _funCtYpe)
				{
					_funCtYpe = value;
					OnPropertyChanged("FunCType");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string ItemName

		private string _itemName;
		[DebuggerNonUserCode]
		[Column(Storage = "_itemName", Name = "item_name", DbType = "varchar(255)")]
		public string ItemName
		{
			get
			{
				return _itemName;
			}
			set
			{
				if (value != _itemName)
				{
					_itemName = value;
					OnPropertyChanged("ItemName");
				}
			}
		}

		#endregion

		#region string ShowName

		private string _showName;
		[DebuggerNonUserCode]
		[Column(Storage = "_showName", Name = "show_name", DbType = "varchar(255)")]
		public string ShowName
		{
			get
			{
				return _showName;
			}
			set
			{
				if (value != _showName)
				{
					_showName = value;
					OnPropertyChanged("ShowName");
				}
			}
		}

		#endregion

		#region string TableName

		private string _tableName;
		[DebuggerNonUserCode]
		[Column(Storage = "_tableName", Name = "table_name", DbType = "varchar(255)")]
		public string TableName
		{
			get
			{
				return _tableName;
			}
			set
			{
				if (value != _tableName)
				{
					_tableName = value;
					OnPropertyChanged("TableName");
				}
			}
		}

		#endregion

		#region sbyte? Wpi

		private sbyte? _wpi;
		[DebuggerNonUserCode]
		[Column(Storage = "_wpi", Name = "wpi", DbType = "tinyint(1)")]
		public sbyte? Wpi
		{
			get
			{
				return _wpi;
			}
			set
			{
				if (value != _wpi)
				{
					_wpi = value;
					OnPropertyChanged("Wpi");
				}
			}
		}

		#endregion

		#region string ZHiBIAO

		private string _zhIBiao;
		[DebuggerNonUserCode]
		[Column(Storage = "_zhIBiao", Name = "zhi_biao", DbType = "varchar(255)")]
		public string ZHiBIAO
		{
			get
			{
				return _zhIBiao;
			}
			set
			{
				if (value != _zhIBiao)
				{
					_zhIBiao = value;
					OnPropertyChanged("ZHiBIAO");
				}
			}
		}

		#endregion

		#region ctor

		public ChartZHIbiAO()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.idx_key")]
	public partial class IDXKey : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region DateTime? CreateTime

		private DateTime? _createTime;
		[DebuggerNonUserCode]
		[Column(Storage = "_createTime", Name = "createtime", DbType = "datetime")]
		public DateTime? CreateTime
		{
			get
			{
				return _createTime;
			}
			set
			{
				if (value != _createTime)
				{
					_createTime = value;
					OnPropertyChanged("CreateTime");
				}
			}
		}

		#endregion

		#region int? CreateUser

		private int? _createUser;
		[DebuggerNonUserCode]
		[Column(Storage = "_createUser", Name = "createuser", DbType = "int")]
		public int? CreateUser
		{
			get
			{
				return _createUser;
			}
			set
			{
				if (value != _createUser)
				{
					_createUser = value;
					OnPropertyChanged("CreateUser");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string IDXKey1

		private string _idxkEy1;
		[DebuggerNonUserCode]
		[Column(Storage = "_idxkEy1", Name = "idx_key", DbType = "varchar(40)")]
		public string IDXKey1
		{
			get
			{
				return _idxkEy1;
			}
			set
			{
				if (value != _idxkEy1)
				{
					_idxkEy1 = value;
					OnPropertyChanged("IDXKey1");
				}
			}
		}

		#endregion

		#region int? Pid

		private int? _pid;
		[DebuggerNonUserCode]
		[Column(Storage = "_pid", Name = "pid", DbType = "int")]
		public int? Pid
		{
			get
			{
				return _pid;
			}
			set
			{
				if (value != _pid)
				{
					_pid = value;
					OnPropertyChanged("Pid");
				}
			}
		}

		#endregion

		#region ctor

		public IDXKey()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.idx_keyval")]
	public partial class IDXKeyVAL : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region DateTime? IDXDate

		private DateTime? _idxdAte;
		[DebuggerNonUserCode]
		[Column(Storage = "_idxdAte", Name = "idxdate", DbType = "datetime")]
		public DateTime? IDXDate
		{
			get
			{
				return _idxdAte;
			}
			set
			{
				if (value != _idxdAte)
				{
					_idxdAte = value;
					OnPropertyChanged("IDXDate");
				}
			}
		}

		#endregion

		#region int? IDXUser

		private int? _idxuSer;
		[DebuggerNonUserCode]
		[Column(Storage = "_idxuSer", Name = "idxuser", DbType = "int")]
		public int? IDXUser
		{
			get
			{
				return _idxuSer;
			}
			set
			{
				if (value != _idxuSer)
				{
					_idxuSer = value;
					OnPropertyChanged("IDXUser");
				}
			}
		}

		#endregion

		#region int? KeyID

		private int? _keyID;
		[DebuggerNonUserCode]
		[Column(Storage = "_keyID", Name = "keyid", DbType = "int")]
		public int? KeyID
		{
			get
			{
				return _keyID;
			}
			set
			{
				if (value != _keyID)
				{
					_keyID = value;
					OnPropertyChanged("KeyID");
				}
			}
		}

		#endregion

		#region int? SiD

		private int? _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "int")]
		public int? SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region int? Valid

		private int? _valid;
		[DebuggerNonUserCode]
		[Column(Storage = "_valid", Name = "valid", DbType = "int")]
		public int? Valid
		{
			get
			{
				return _valid;
			}
			set
			{
				if (value != _valid)
				{
					_valid = value;
					OnPropertyChanged("Valid");
				}
			}
		}

		#endregion

		#region int? ZID

		private int? _zid;
		[DebuggerNonUserCode]
		[Column(Storage = "_zid", Name = "zid", DbType = "int")]
		public int? ZID
		{
			get
			{
				return _zid;
			}
			set
			{
				if (value != _zid)
				{
					_zid = value;
					OnPropertyChanged("ZID");
				}
			}
		}

		#endregion

		#region ctor

		public IDXKeyVAL()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.idx_val")]
	public partial class IDXVAL : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string AutoIDXContent

		private string _autoIdxcOntent;
		[DebuggerNonUserCode]
		[Column(Storage = "_autoIdxcOntent", Name = "auto_idx_content", DbType = "varchar(500)")]
		public string AutoIDXContent
		{
			get
			{
				return _autoIdxcOntent;
			}
			set
			{
				if (value != _autoIdxcOntent)
				{
					_autoIdxcOntent = value;
					OnPropertyChanged("AutoIDXContent");
				}
			}
		}

		#endregion

		#region DateTime? CreateTime

		private DateTime? _createTime;
		[DebuggerNonUserCode]
		[Column(Storage = "_createTime", Name = "createtime", DbType = "datetime")]
		public DateTime? CreateTime
		{
			get
			{
				return _createTime;
			}
			set
			{
				if (value != _createTime)
				{
					_createTime = value;
					OnPropertyChanged("CreateTime");
				}
			}
		}

		#endregion

		#region int? CreateUser

		private int? _createUser;
		[DebuggerNonUserCode]
		[Column(Storage = "_createUser", Name = "createuser", DbType = "int")]
		public int? CreateUser
		{
			get
			{
				return _createUser;
			}
			set
			{
				if (value != _createUser)
				{
					_createUser = value;
					OnPropertyChanged("CreateUser");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region int? KeyID

		private int? _keyID;
		[DebuggerNonUserCode]
		[Column(Storage = "_keyID", Name = "keyid", DbType = "int")]
		public int? KeyID
		{
			get
			{
				return _keyID;
			}
			set
			{
				if (value != _keyID)
				{
					_keyID = value;
					OnPropertyChanged("KeyID");
				}
			}
		}

		#endregion

		#region int? Pid

		private int? _pid;
		[DebuggerNonUserCode]
		[Column(Storage = "_pid", Name = "pid", DbType = "int")]
		public int? Pid
		{
			get
			{
				return _pid;
			}
			set
			{
				if (value != _pid)
				{
					_pid = value;
					OnPropertyChanged("Pid");
				}
			}
		}

		#endregion

		#region string VAL

		private string _val;
		[DebuggerNonUserCode]
		[Column(Storage = "_val", Name = "val", DbType = "varchar(40)")]
		public string VAL
		{
			get
			{
				return _val;
			}
			set
			{
				if (value != _val)
				{
					_val = value;
					OnPropertyChanged("VAL");
				}
			}
		}

		#endregion

		#region ctor

		public IDXVAL()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.show_base")]
	public partial class ShowBase : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string ABs

		private string _abS;
		[DebuggerNonUserCode]
		[Column(Storage = "_abS", Name = "abs", DbType = "text")]
		public string ABs
		{
			get
			{
				return _abS;
			}
			set
			{
				if (value != _abS)
				{
					_abS = value;
					OnPropertyChanged("ABs");
				}
			}
		}

		#endregion

		#region string Ad

		private string _ad;
		[DebuggerNonUserCode]
		[Column(Storage = "_ad", Name = "ad", DbType = "varchar(20)")]
		public string Ad
		{
			get
			{
				return _ad;
			}
			set
			{
				if (value != _ad)
				{
					_ad = value;
					OnPropertyChanged("Ad");
				}
			}
		}

		#endregion

		#region string AddR

		private string _addR;
		[DebuggerNonUserCode]
		[Column(Storage = "_addR", Name = "addr", DbType = "varchar(255)")]
		public string AddR
		{
			get
			{
				return _addR;
			}
			set
			{
				if (value != _addR)
				{
					_addR = value;
					OnPropertyChanged("AddR");
				}
			}
		}

		#endregion

		#region string An

		private string _an;
		[DebuggerNonUserCode]
		[Column(Storage = "_an", Name = "an", DbType = "text")]
		public string An
		{
			get
			{
				return _an;
			}
			set
			{
				if (value != _an)
				{
					_an = value;
					OnPropertyChanged("An");
				}
			}
		}

		#endregion

		#region string ClM

		private string _clM;
		[DebuggerNonUserCode]
		[Column(Storage = "_clM", Name = "CLM", DbType = "text")]
		public string ClM
		{
			get
			{
				return _clM;
			}
			set
			{
				if (value != _clM)
				{
					_clM = value;
					OnPropertyChanged("ClM");
				}
			}
		}

		#endregion

		#region string ClMSum

		private string _clMsUm;
		[DebuggerNonUserCode]
		[Column(Storage = "_clMsUm", Name = "clm_sum", DbType = "varchar(4)")]
		public string ClMSum
		{
			get
			{
				return _clMsUm;
			}
			set
			{
				if (value != _clMsUm)
				{
					_clMsUm = value;
					OnPropertyChanged("ClMSum");
				}
			}
		}

		#endregion

		#region string CPc

		private string _cpC;
		[DebuggerNonUserCode]
		[Column(Storage = "_cpC", Name = "cpc", DbType = "text")]
		public string CPc
		{
			get
			{
				return _cpC;
			}
			set
			{
				if (value != _cpC)
				{
					_cpC = value;
					OnPropertyChanged("CPc");
				}
			}
		}

		#endregion

		#region string CPY

		private string _cpy;
		[DebuggerNonUserCode]
		[Column(Storage = "_cpy", Name = "cpy", DbType = "varchar(500)")]
		public string CPY
		{
			get
			{
				return _cpy;
			}
			set
			{
				if (value != _cpy)
				{
					_cpy = value;
					OnPropertyChanged("CPY");
				}
			}
		}

		#endregion

		#region string Ct

		private string _ct;
		[DebuggerNonUserCode]
		[Column(Storage = "_ct", Name = "CT", DbType = "text")]
		public string Ct
		{
			get
			{
				return _ct;
			}
			set
			{
				if (value != _ct)
				{
					_ct = value;
					OnPropertyChanged("Ct");
				}
			}
		}

		#endregion

		#region string CtNP

		private string _ctNp;
		[DebuggerNonUserCode]
		[Column(Storage = "_ctNp", Name = "CTNP", DbType = "text")]
		public string CtNP
		{
			get
			{
				return _ctNp;
			}
			set
			{
				if (value != _ctNp)
				{
					_ctNp = value;
					OnPropertyChanged("CtNP");
				}
			}
		}

		#endregion

		#region string DesPageSum

		private string _desPageSum;
		[DebuggerNonUserCode]
		[Column(Storage = "_desPageSum", Name = "des_page_sum", DbType = "varchar(4)")]
		public string DesPageSum
		{
			get
			{
				return _desPageSum;
			}
			set
			{
				if (value != _desPageSum)
				{
					_desPageSum = value;
					OnPropertyChanged("DesPageSum");
				}
			}
		}

		#endregion

		#region string DLJG

		private string _dljg;
		[DebuggerNonUserCode]
		[Column(Storage = "_dljg", Name = "dljg", DbType = "varchar(255)")]
		public string DLJG
		{
			get
			{
				return _dljg;
			}
			set
			{
				if (value != _dljg)
				{
					_dljg = value;
					OnPropertyChanged("DLJG");
				}
			}
		}

		#endregion

		#region string DLJGAddR

		private string _dljgaDdR;
		[DebuggerNonUserCode]
		[Column(Storage = "_dljgaDdR", Name = "dljg_addr", DbType = "varchar(255)")]
		public string DLJGAddR
		{
			get
			{
				return _dljgaDdR;
			}
			set
			{
				if (value != _dljgaDdR)
				{
					_dljgaDdR = value;
					OnPropertyChanged("DLJGAddR");
				}
			}
		}

		#endregion

		#region string DLr

		private string _dlR;
		[DebuggerNonUserCode]
		[Column(Storage = "_dlR", Name = "dlr", DbType = "varchar(255)")]
		public string DLr
		{
			get
			{
				return _dlR;
			}
			set
			{
				if (value != _dlR)
				{
					_dlR = value;
					OnPropertyChanged("DLr");
				}
			}
		}

		#endregion

		#region string DMc

		private string _dmC;
		[DebuggerNonUserCode]
		[Column(Storage = "_dmC", Name = "dmc", DbType = "text")]
		public string DMc
		{
			get
			{
				return _dmC;
			}
			set
			{
				if (value != _dmC)
				{
					_dmC = value;
					OnPropertyChanged("DMc");
				}
			}
		}

		#endregion

		#region string DS

		private string _ds;
		[DebuggerNonUserCode]
		[Column(Storage = "_ds", Name = "DS", DbType = "varchar(255)")]
		public string DS
		{
			get
			{
				return _ds;
			}
			set
			{
				if (value != _ds)
				{
					_ds = value;
					OnPropertyChanged("DS");
				}
			}
		}

		#endregion

		#region string Ec

		private string _ec;
		[DebuggerNonUserCode]
		[Column(Storage = "_ec", Name = "EC", DbType = "text")]
		public string Ec
		{
			get
			{
				return _ec;
			}
			set
			{
				if (value != _ec)
				{
					_ec = value;
					OnPropertyChanged("Ec");
				}
			}
		}

		#endregion

		#region string FaMN

		private string _faMn;
		[DebuggerNonUserCode]
		[Column(Storage = "_faMn", Name = "FAMN", DbType = "varchar(50)")]
		public string FaMN
		{
			get
			{
				return _faMn;
			}
			set
			{
				if (value != _faMn)
				{
					_faMn = value;
					OnPropertyChanged("FaMN");
				}
			}
		}

		#endregion

		#region string FCfL

		private string _fcFL;
		[DebuggerNonUserCode]
		[Column(Storage = "_fcFL", Name = "FCFL", DbType = "varchar(20)")]
		public string FCfL
		{
			get
			{
				return _fcFL;
			}
			set
			{
				if (value != _fcFL)
				{
					_fcFL = value;
					OnPropertyChanged("FCfL");
				}
			}
		}

		#endregion

		#region string FI

		private string _fi;
		[DebuggerNonUserCode]
		[Column(Storage = "_fi", Name = "FI", DbType = "text")]
		public string FI
		{
			get
			{
				return _fi;
			}
			set
			{
				if (value != _fi)
				{
					_fi = value;
					OnPropertyChanged("FI");
				}
			}
		}

		#endregion

		#region string FT

		private string _ft;
		[DebuggerNonUserCode]
		[Column(Storage = "_ft", Name = "FT", DbType = "text")]
		public string FT
		{
			get
			{
				return _ft;
			}
			set
			{
				if (value != _ft)
				{
					_ft = value;
					OnPropertyChanged("FT");
				}
			}
		}

		#endregion

		#region string Gd

		private string _gd;
		[DebuggerNonUserCode]
		[Column(Storage = "_gd", Name = "gd", DbType = "varchar(20)")]
		public string Gd
		{
			get
			{
				return _gd;
			}
			set
			{
				if (value != _gd)
				{
					_gd = value;
					OnPropertyChanged("Gd");
				}
			}
		}

		#endregion

		#region string GN

		private string _gn;
		[DebuggerNonUserCode]
		[Column(Storage = "_gn", Name = "gn", DbType = "varchar(25)")]
		public string GN
		{
			get
			{
				return _gn;
			}
			set
			{
				if (value != _gn)
				{
					_gn = value;
					OnPropertyChanged("GN");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region DateTime? ImportDate

		private DateTime? _importDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_importDate", Name = "import_date", DbType = "datetime")]
		public DateTime? ImportDate
		{
			get
			{
				return _importDate;
			}
			set
			{
				if (value != _importDate)
				{
					_importDate = value;
					OnPropertyChanged("ImportDate");
				}
			}
		}

		#endregion

		#region string Ipc

		private string _ipc;
		[DebuggerNonUserCode]
		[Column(Storage = "_ipc", Name = "ipc", DbType = "text")]
		public string Ipc
		{
			get
			{
				return _ipc;
			}
			set
			{
				if (value != _ipc)
				{
					_ipc = value;
					OnPropertyChanged("Ipc");
				}
			}
		}

		#endregion

		#region string IV

		private string _iv;
		[DebuggerNonUserCode]
		[Column(Storage = "_iv", Name = "iv", DbType = "text")]
		public string IV
		{
			get
			{
				return _iv;
			}
			set
			{
				if (value != _iv)
				{
					_iv = value;
					OnPropertyChanged("IV");
				}
			}
		}

		#endregion

		#region string LG

		private string _lg;
		[DebuggerNonUserCode]
		[Column(Storage = "_lg", Name = "lg", DbType = "text")]
		public string LG
		{
			get
			{
				return _lg;
			}
			set
			{
				if (value != _lg)
				{
					_lg = value;
					OnPropertyChanged("LG");
				}
			}
		}

		#endregion

		#region string MAd

		private string _maD;
		[DebuggerNonUserCode]
		[Column(Storage = "_maD", Name = "m_ad", DbType = "varchar(8)")]
		public string MAd
		{
			get
			{
				return _maD;
			}
			set
			{
				if (value != _maD)
				{
					_maD = value;
					OnPropertyChanged("MAd");
				}
			}
		}

		#endregion

		#region string OpD

		private string _opD;
		[DebuggerNonUserCode]
		[Column(Storage = "_opD", Name = "opd", DbType = "varchar(25)")]
		public string OpD
		{
			get
			{
				return _opD;
			}
			set
			{
				if (value != _opD)
				{
					_opD = value;
					OnPropertyChanged("OpD");
				}
			}
		}

		#endregion

		#region string Pa

		private string _pa;
		[DebuggerNonUserCode]
		[Column(Storage = "_pa", Name = "pa", DbType = "text")]
		public string Pa
		{
			get
			{
				return _pa;
			}
			set
			{
				if (value != _pa)
				{
					_pa = value;
					OnPropertyChanged("Pa");
				}
			}
		}

		#endregion

		#region string PcDIn

		private string _pcDiN;
		[DebuggerNonUserCode]
		[Column(Storage = "_pcDiN", Name = "pcd_in", DbType = "varchar(20)")]
		public string PcDIn
		{
			get
			{
				return _pcDiN;
			}
			set
			{
				if (value != _pcDiN)
				{
					_pcDiN = value;
					OnPropertyChanged("PcDIn");
				}
			}
		}

		#endregion

		#region string PcTAd

		private string _pcTaD;
		[DebuggerNonUserCode]
		[Column(Storage = "_pcTaD", Name = "pct_ad", DbType = "varchar(20)")]
		public string PcTAd
		{
			get
			{
				return _pcTaD;
			}
			set
			{
				if (value != _pcTaD)
				{
					_pcTaD = value;
					OnPropertyChanged("PcTAd");
				}
			}
		}

		#endregion

		#region string PcTAn

		private string _pcTaN;
		[DebuggerNonUserCode]
		[Column(Storage = "_pcTaN", Name = "pct_an", DbType = "varchar(25)")]
		public string PcTAn
		{
			get
			{
				return _pcTaN;
			}
			set
			{
				if (value != _pcTaN)
				{
					_pcTaN = value;
					OnPropertyChanged("PcTAn");
				}
			}
		}

		#endregion

		#region string PcTGd

		private string _pcTgD;
		[DebuggerNonUserCode]
		[Column(Storage = "_pcTgD", Name = "pct_gd", DbType = "varchar(8)")]
		public string PcTGd
		{
			get
			{
				return _pcTgD;
			}
			set
			{
				if (value != _pcTgD)
				{
					_pcTgD = value;
					OnPropertyChanged("PcTGd");
				}
			}
		}

		#endregion

		#region string PcTPN

		private string _pcTpn;
		[DebuggerNonUserCode]
		[Column(Storage = "_pcTpn", Name = "pct_pn", DbType = "varchar(25)")]
		public string PcTPN
		{
			get
			{
				return _pcTpn;
			}
			set
			{
				if (value != _pcTpn)
				{
					_pcTpn = value;
					OnPropertyChanged("PcTPN");
				}
			}
		}

		#endregion

		#region string PD

		private string _pd;
		[DebuggerNonUserCode]
		[Column(Storage = "_pd", Name = "pd", DbType = "varchar(20)")]
		public string PD
		{
			get
			{
				return _pd;
			}
			set
			{
				if (value != _pd)
				{
					_pd = value;
					OnPropertyChanged("PD");
				}
			}
		}

		#endregion

		#region string PiCSum

		private string _piCsUm;
		[DebuggerNonUserCode]
		[Column(Storage = "_piCsUm", Name = "pic_sum", DbType = "varchar(4)")]
		public string PiCSum
		{
			get
			{
				return _piCsUm;
			}
			set
			{
				if (value != _piCsUm)
				{
					_piCsUm = value;
					OnPropertyChanged("PiCSum");
				}
			}
		}

		#endregion

		#region string PN

		private string _pn;
		[DebuggerNonUserCode]
		[Column(Storage = "_pn", Name = "pn", DbType = "text")]
		public string PN
		{
			get
			{
				return _pn;
			}
			set
			{
				if (value != _pn)
				{
					_pn = value;
					OnPropertyChanged("PN");
				}
			}
		}

		#endregion

		#region string PR

		private string _pr;
		[DebuggerNonUserCode]
		[Column(Storage = "_pr", Name = "pr", DbType = "text")]
		public string PR
		{
			get
			{
				return _pr;
			}
			set
			{
				if (value != _pr)
				{
					_pr = value;
					OnPropertyChanged("PR");
				}
			}
		}

		#endregion

		#region string RF

		private string _rf;
		[DebuggerNonUserCode]
		[Column(Storage = "_rf", Name = "RF", DbType = "text")]
		public string RF
		{
			get
			{
				return _rf;
			}
			set
			{
				if (value != _rf)
				{
					_rf = value;
					OnPropertyChanged("RF");
				}
			}
		}

		#endregion

		#region string RFaP

		private string _rfAP;
		[DebuggerNonUserCode]
		[Column(Storage = "_rfAP", Name = "RFAP", DbType = "text")]
		public string RFaP
		{
			get
			{
				return _rfAP;
			}
			set
			{
				if (value != _rfAP)
				{
					_rfAP = value;
					OnPropertyChanged("RFaP");
				}
			}
		}

		#endregion

		#region string RFNP

		private string _rfnp;
		[DebuggerNonUserCode]
		[Column(Storage = "_rfnp", Name = "RFNP", DbType = "text")]
		public string RFNP
		{
			get
			{
				return _rfnp;
			}
			set
			{
				if (value != _rfnp)
				{
					_rfnp = value;
					OnPropertyChanged("RFNP");
				}
			}
		}

		#endregion

		#region string ShEng

		private string _shEng;
		[DebuggerNonUserCode]
		[Column(Storage = "_shEng", Name = "sheng", DbType = "varchar(20)")]
		public string ShEng
		{
			get
			{
				return _shEng;
			}
			set
			{
				if (value != _shEng)
				{
					_shEng = value;
					OnPropertyChanged("ShEng");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(25)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region string Title

		private string _title;
		[DebuggerNonUserCode]
		[Column(Storage = "_title", Name = "title", DbType = "varchar(500)")]
		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				if (value != _title)
				{
					_title = value;
					OnPropertyChanged("Title");
				}
			}
		}

		#endregion

		#region string Zip

		private string _zip;
		[DebuggerNonUserCode]
		[Column(Storage = "_zip", Name = "zip", DbType = "varchar(10)")]
		public string Zip
		{
			get
			{
				return _zip;
			}
			set
			{
				if (value != _zip)
				{
					_zip = value;
					OnPropertyChanged("Zip");
				}
			}
		}

		#endregion

		#region int? ZTID

		private int? _ztid;
		[DebuggerNonUserCode]
		[Column(Storage = "_ztid", Name = "ztid", DbType = "int")]
		public int? ZTID
		{
			get
			{
				return _ztid;
			}
			set
			{
				if (value != _ztid)
				{
					_ztid = value;
					OnPropertyChanged("ZTID");
				}
			}
		}

		#endregion

		#region ctor

		public ShowBase()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_ans")]
	public partial class STAnS : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Ad

		private string _ad;
		[DebuggerNonUserCode]
		[Column(Storage = "_ad", Name = "ad", DbType = "varchar(8)")]
		public string Ad
		{
			get
			{
				return _ad;
			}
			set
			{
				if (value != _ad)
				{
					_ad = value;
					OnPropertyChanged("Ad");
				}
			}
		}

		#endregion

		#region string AdY

		private string _adY;
		[DebuggerNonUserCode]
		[Column(Storage = "_adY", Name = "ady", DbType = "varchar(4)")]
		public string AdY
		{
			get
			{
				return _adY;
			}
			set
			{
				if (value != _adY)
				{
					_adY = value;
					OnPropertyChanged("AdY");
				}
			}
		}

		#endregion

		#region string An

		private string _an;
		[DebuggerNonUserCode]
		[Column(Storage = "_an", Name = "an", DbType = "varchar(25)")]
		public string An
		{
			get
			{
				return _an;
			}
			set
			{
				if (value != _an)
				{
					_an = value;
					OnPropertyChanged("An");
				}
			}
		}

		#endregion

		#region string AnGJ

		private string _anGj;
		[DebuggerNonUserCode]
		[Column(Storage = "_anGj", Name = "an_gj", DbType = "varchar(2)")]
		public string AnGJ
		{
			get
			{
				return _anGj;
			}
			set
			{
				if (value != _anGj)
				{
					_anGj = value;
					OnPropertyChanged("AnGJ");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(25)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region sbyte? Sort

		private sbyte? _sort;
		[DebuggerNonUserCode]
		[Column(Storage = "_sort", Name = "sort", DbType = "tinyint(4)")]
		public sbyte? Sort
		{
			get
			{
				return _sort;
			}
			set
			{
				if (value != _sort)
				{
					_sort = value;
					OnPropertyChanged("Sort");
				}
			}
		}

		#endregion

		#region ctor

		public STAnS()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_cpc")]
	public partial class STCPc : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string CPc

		private string _cpC;
		[DebuggerNonUserCode]
		[Column(Storage = "_cpC", Name = "cpc", DbType = "varchar(20)")]
		public string CPc
		{
			get
			{
				return _cpC;
			}
			set
			{
				if (value != _cpC)
				{
					_cpC = value;
					OnPropertyChanged("CPc");
				}
			}
		}

		#endregion

		#region string CPc1

		private string _cpC1;
		[DebuggerNonUserCode]
		[Column(Storage = "_cpC1", Name = "cpc1", DbType = "char(1)")]
		public string CPc1
		{
			get
			{
				return _cpC1;
			}
			set
			{
				if (value != _cpC1)
				{
					_cpC1 = value;
					OnPropertyChanged("CPc1");
				}
			}
		}

		#endregion

		#region string CPc3

		private string _cpC3;
		[DebuggerNonUserCode]
		[Column(Storage = "_cpC3", Name = "cpc3", DbType = "varchar(3)")]
		public string CPc3
		{
			get
			{
				return _cpC3;
			}
			set
			{
				if (value != _cpC3)
				{
					_cpC3 = value;
					OnPropertyChanged("CPc3");
				}
			}
		}

		#endregion

		#region string CPc4

		private string _cpC4;
		[DebuggerNonUserCode]
		[Column(Storage = "_cpC4", Name = "cpc4", DbType = "varchar(4)")]
		public string CPc4
		{
			get
			{
				return _cpC4;
			}
			set
			{
				if (value != _cpC4)
				{
					_cpC4 = value;
					OnPropertyChanged("CPc4");
				}
			}
		}

		#endregion

		#region string CPc7

		private string _cpC7;
		[DebuggerNonUserCode]
		[Column(Storage = "_cpC7", Name = "cpc7", DbType = "varchar(7)")]
		public string CPc7
		{
			get
			{
				return _cpC7;
			}
			set
			{
				if (value != _cpC7)
				{
					_cpC7 = value;
					OnPropertyChanged("CPc7");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(11)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region sbyte? Sort

		private sbyte? _sort;
		[DebuggerNonUserCode]
		[Column(Storage = "_sort", Name = "sort", DbType = "tinyint(4)")]
		public sbyte? Sort
		{
			get
			{
				return _sort;
			}
			set
			{
				if (value != _sort)
				{
					_sort = value;
					OnPropertyChanged("Sort");
				}
			}
		}

		#endregion

		#region ctor

		public STCPc()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_ct")]
	public partial class STCt : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string CtNo

		private string _ctNo;
		[DebuggerNonUserCode]
		[Column(Storage = "_ctNo", Name = "ct_no", DbType = "varchar(25)")]
		public string CtNo
		{
			get
			{
				return _ctNo;
			}
			set
			{
				if (value != _ctNo)
				{
					_ctNo = value;
					OnPropertyChanged("CtNo");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string PN

		private string _pn;
		[DebuggerNonUserCode]
		[Column(Storage = "_pn", Name = "pn", DbType = "varchar(25)")]
		public string PN
		{
			get
			{
				return _pn;
			}
			set
			{
				if (value != _pn)
				{
					_pn = value;
					OnPropertyChanged("PN");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(11)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region ctor

		public STCt()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_dmc")]
	public partial class STDMc : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string DMc

		private string _dmC;
		[DebuggerNonUserCode]
		[Column(Storage = "_dmC", Name = "dmc", DbType = "varchar(20)")]
		public string DMc
		{
			get
			{
				return _dmC;
			}
			set
			{
				if (value != _dmC)
				{
					_dmC = value;
					OnPropertyChanged("DMc");
				}
			}
		}

		#endregion

		#region string DMc1

		private string _dmC1;
		[DebuggerNonUserCode]
		[Column(Storage = "_dmC1", Name = "dmc1", DbType = "char(1)")]
		public string DMc1
		{
			get
			{
				return _dmC1;
			}
			set
			{
				if (value != _dmC1)
				{
					_dmC1 = value;
					OnPropertyChanged("DMc1");
				}
			}
		}

		#endregion

		#region string DMc3

		private string _dmC3;
		[DebuggerNonUserCode]
		[Column(Storage = "_dmC3", Name = "dmc3", DbType = "varchar(3)")]
		public string DMc3
		{
			get
			{
				return _dmC3;
			}
			set
			{
				if (value != _dmC3)
				{
					_dmC3 = value;
					OnPropertyChanged("DMc3");
				}
			}
		}

		#endregion

		#region string DMc4

		private string _dmC4;
		[DebuggerNonUserCode]
		[Column(Storage = "_dmC4", Name = "dmc4", DbType = "varchar(4)")]
		public string DMc4
		{
			get
			{
				return _dmC4;
			}
			set
			{
				if (value != _dmC4)
				{
					_dmC4 = value;
					OnPropertyChanged("DMc4");
				}
			}
		}

		#endregion

		#region string DMc7

		private string _dmC7;
		[DebuggerNonUserCode]
		[Column(Storage = "_dmC7", Name = "dmc7", DbType = "varchar(7)")]
		public string DMc7
		{
			get
			{
				return _dmC7;
			}
			set
			{
				if (value != _dmC7)
				{
					_dmC7 = value;
					OnPropertyChanged("DMc7");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(25)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region sbyte? Sort

		private sbyte? _sort;
		[DebuggerNonUserCode]
		[Column(Storage = "_sort", Name = "sort", DbType = "tinyint(4)")]
		public sbyte? Sort
		{
			get
			{
				return _sort;
			}
			set
			{
				if (value != _sort)
				{
					_sort = value;
					OnPropertyChanged("Sort");
				}
			}
		}

		#endregion

		#region ctor

		public STDMc()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_dt")]
	public partial class STDT : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Ad

		private string _ad;
		[DebuggerNonUserCode]
		[Column(Storage = "_ad", Name = "ad", DbType = "varchar(8)")]
		public string Ad
		{
			get
			{
				return _ad;
			}
			set
			{
				if (value != _ad)
				{
					_ad = value;
					OnPropertyChanged("Ad");
				}
			}
		}

		#endregion

		#region int? AdY

		private int? _adY;
		[DebuggerNonUserCode]
		[Column(Storage = "_adY", Name = "ady", DbType = "int")]
		public int? AdY
		{
			get
			{
				return _adY;
			}
			set
			{
				if (value != _adY)
				{
					_adY = value;
					OnPropertyChanged("AdY");
				}
			}
		}

		#endregion

		#region sbyte? Age

		private sbyte? _age;
		[DebuggerNonUserCode]
		[Column(Storage = "_age", Name = "age", DbType = "tinyint(4)")]
		public sbyte? Age
		{
			get
			{
				return _age;
			}
			set
			{
				if (value != _age)
				{
					_age = value;
					OnPropertyChanged("Age");
				}
			}
		}

		#endregion

		#region string An

		private string _an;
		[DebuggerNonUserCode]
		[Column(Storage = "_an", Name = "an", DbType = "varchar(25)")]
		public string An
		{
			get
			{
				return _an;
			}
			set
			{
				if (value != _an)
				{
					_an = value;
					OnPropertyChanged("An");
				}
			}
		}

		#endregion

		#region sbyte? ByZSum

		private sbyte? _byZsUm;
		[DebuggerNonUserCode]
		[Column(Storage = "_byZsUm", Name = "byz_sum", DbType = "tinyint(4)")]
		public sbyte? ByZSum
		{
			get
			{
				return _byZsUm;
			}
			set
			{
				if (value != _byZsUm)
				{
					_byZsUm = value;
					OnPropertyChanged("ByZSum");
				}
			}
		}

		#endregion

		#region int? ClMPageSum

		private int? _clMpAgeSum;
		[DebuggerNonUserCode]
		[Column(Storage = "_clMpAgeSum", Name = "clm_page_sum", DbType = "int")]
		public int? ClMPageSum
		{
			get
			{
				return _clMpAgeSum;
			}
			set
			{
				if (value != _clMpAgeSum)
				{
					_clMpAgeSum = value;
					OnPropertyChanged("ClMPageSum");
				}
			}
		}

		#endregion

		#region int? ClSCharSum

		private int? _clScHarSum;
		[DebuggerNonUserCode]
		[Column(Storage = "_clScHarSum", Name = "cls_char_sum", DbType = "int")]
		public int? ClSCharSum
		{
			get
			{
				return _clScHarSum;
			}
			set
			{
				if (value != _clScHarSum)
				{
					_clScHarSum = value;
					OnPropertyChanged("ClSCharSum");
				}
			}
		}

		#endregion

		#region sbyte? CPcSum

		private sbyte? _cpCSum;
		[DebuggerNonUserCode]
		[Column(Storage = "_cpCSum", Name = "cpc_sum", DbType = "tinyint(4)")]
		public sbyte? CPcSum
		{
			get
			{
				return _cpCSum;
			}
			set
			{
				if (value != _cpCSum)
				{
					_cpCSum = value;
					OnPropertyChanged("CPcSum");
				}
			}
		}

		#endregion

		#region int? DesPageSum

		private int? _desPageSum;
		[DebuggerNonUserCode]
		[Column(Storage = "_desPageSum", Name = "des_page_sum", DbType = "int")]
		public int? DesPageSum
		{
			get
			{
				return _desPageSum;
			}
			set
			{
				if (value != _desPageSum)
				{
					_desPageSum = value;
					OnPropertyChanged("DesPageSum");
				}
			}
		}

		#endregion

		#region sbyte? DMcSum

		private sbyte? _dmCSum;
		[DebuggerNonUserCode]
		[Column(Storage = "_dmCSum", Name = "dmc_sum", DbType = "tinyint(4)")]
		public sbyte? DMcSum
		{
			get
			{
				return _dmCSum;
			}
			set
			{
				if (value != _dmCSum)
				{
					_dmCSum = value;
					OnPropertyChanged("DMcSum");
				}
			}
		}

		#endregion

		#region string FCPc

		private string _fcpC;
		[DebuggerNonUserCode]
		[Column(Storage = "_fcpC", Name = "f_cpc", DbType = "varchar(20)")]
		public string FCPc
		{
			get
			{
				return _fcpC;
			}
			set
			{
				if (value != _fcpC)
				{
					_fcpC = value;
					OnPropertyChanged("FCPc");
				}
			}
		}

		#endregion

		#region string FDMc

		private string _fdmC;
		[DebuggerNonUserCode]
		[Column(Storage = "_fdmC", Name = "f_dmc", DbType = "varchar(20)")]
		public string FDMc
		{
			get
			{
				return _fdmC;
			}
			set
			{
				if (value != _fdmC)
				{
					_fdmC = value;
					OnPropertyChanged("FDMc");
				}
			}
		}

		#endregion

		#region string FIn

		private string _fiN;
		[DebuggerNonUserCode]
		[Column(Storage = "_fiN", Name = "f_in", DbType = "varchar(80)")]
		public string FIn
		{
			get
			{
				return _fiN;
			}
			set
			{
				if (value != _fiN)
				{
					_fiN = value;
					OnPropertyChanged("FIn");
				}
			}
		}

		#endregion

		#region string FIpc

		private string _fiPc;
		[DebuggerNonUserCode]
		[Column(Storage = "_fiPc", Name = "f_ipc", DbType = "varchar(20)")]
		public string FIpc
		{
			get
			{
				return _fiPc;
			}
			set
			{
				if (value != _fiPc)
				{
					_fiPc = value;
					OnPropertyChanged("FIpc");
				}
			}
		}

		#endregion

		#region int? FMLSum

		private int? _fmlsUm;
		[DebuggerNonUserCode]
		[Column(Storage = "_fmlsUm", Name = "fml_sum", DbType = "int")]
		public int? FMLSum
		{
			get
			{
				return _fmlsUm;
			}
			set
			{
				if (value != _fmlsUm)
				{
					_fmlsUm = value;
					OnPropertyChanged("FMLSum");
				}
			}
		}

		#endregion

		#region string FPa

		private string _fpA;
		[DebuggerNonUserCode]
		[Column(Storage = "_fpA", Name = "f_pa", DbType = "varchar(80)")]
		public string FPa
		{
			get
			{
				return _fpA;
			}
			set
			{
				if (value != _fpA)
				{
					_fpA = value;
					OnPropertyChanged("FPa");
				}
			}
		}

		#endregion

		#region string FPaType

		private string _fpAType;
		[DebuggerNonUserCode]
		[Column(Storage = "_fpAType", Name = "f_pa_type", DbType = "varchar(8)")]
		public string FPaType
		{
			get
			{
				return _fpAType;
			}
			set
			{
				if (value != _fpAType)
				{
					_fpAType = value;
					OnPropertyChanged("FPaType");
				}
			}
		}

		#endregion

		#region string Gd

		private string _gd;
		[DebuggerNonUserCode]
		[Column(Storage = "_gd", Name = "gd", DbType = "varchar(8)")]
		public string Gd
		{
			get
			{
				return _gd;
			}
			set
			{
				if (value != _gd)
				{
					_gd = value;
					OnPropertyChanged("Gd");
				}
			}
		}

		#endregion

		#region int? GdY

		private int? _gdY;
		[DebuggerNonUserCode]
		[Column(Storage = "_gdY", Name = "gdy", DbType = "int")]
		public int? GdY
		{
			get
			{
				return _gdY;
			}
			set
			{
				if (value != _gdY)
				{
					_gdY = value;
					OnPropertyChanged("GdY");
				}
			}
		}

		#endregion

		#region sbyte? GdYDef

		private sbyte? _gdYdEf;
		[DebuggerNonUserCode]
		[Column(Storage = "_gdYdEf", Name = "gdy_def", DbType = "tinyint(4)")]
		public sbyte? GdYDef
		{
			get
			{
				return _gdYdEf;
			}
			set
			{
				if (value != _gdYdEf)
				{
					_gdYdEf = value;
					OnPropertyChanged("GdYDef");
				}
			}
		}

		#endregion

		#region string GJ

		private string _gj;
		[DebuggerNonUserCode]
		[Column(Storage = "_gj", Name = "gj", DbType = "varchar(20)")]
		public string GJ
		{
			get
			{
				return _gj;
			}
			set
			{
				if (value != _gj)
				{
					_gj = value;
					OnPropertyChanged("GJ");
				}
			}
		}

		#endregion

		#region sbyte? GJSum

		private sbyte? _gjsUm;
		[DebuggerNonUserCode]
		[Column(Storage = "_gjsUm", Name = "gj_sum", DbType = "tinyint(4)")]
		public sbyte? GJSum
		{
			get
			{
				return _gjsUm;
			}
			set
			{
				if (value != _gjsUm)
				{
					_gjsUm = value;
					OnPropertyChanged("GJSum");
				}
			}
		}

		#endregion

		#region string GN

		private string _gn;
		[DebuggerNonUserCode]
		[Column(Storage = "_gn", Name = "gn", DbType = "varchar(25)")]
		public string GN
		{
			get
			{
				return _gn;
			}
			set
			{
				if (value != _gn)
				{
					_gn = value;
					OnPropertyChanged("GN");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region DateTime? ImportDate

		private DateTime? _importDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_importDate", Name = "import_date", DbType = "datetime")]
		public DateTime? ImportDate
		{
			get
			{
				return _importDate;
			}
			set
			{
				if (value != _importDate)
				{
					_importDate = value;
					OnPropertyChanged("ImportDate");
				}
			}
		}

		#endregion

		#region sbyte? InSum

		private sbyte? _inSum;
		[DebuggerNonUserCode]
		[Column(Storage = "_inSum", Name = "in_sum", DbType = "tinyint(4)")]
		public sbyte? InSum
		{
			get
			{
				return _inSum;
			}
			set
			{
				if (value != _inSum)
				{
					_inSum = value;
					OnPropertyChanged("InSum");
				}
			}
		}

		#endregion

		#region sbyte? IpcSum

		private sbyte? _ipcSum;
		[DebuggerNonUserCode]
		[Column(Storage = "_ipcSum", Name = "ipc_sum", DbType = "tinyint(4)")]
		public sbyte? IpcSum
		{
			get
			{
				return _ipcSum;
			}
			set
			{
				if (value != _ipcSum)
				{
					_ipcSum = value;
					OnPropertyChanged("IpcSum");
				}
			}
		}

		#endregion

		#region sbyte? IsGongZHi

		private sbyte? _isGongZhI;
		[DebuggerNonUserCode]
		[Column(Storage = "_isGongZhI", Name = "isgongzhi", DbType = "tinyint(4)")]
		public sbyte? IsGongZHi
		{
			get
			{
				return _isGongZhI;
			}
			set
			{
				if (value != _isGongZhI)
				{
					_isGongZhI = value;
					OnPropertyChanged("IsGongZHi");
				}
			}
		}

		#endregion

		#region sbyte? IsGuOwAi

		private sbyte? _isGuOwAi;
		[DebuggerNonUserCode]
		[Column(Storage = "_isGuOwAi", Name = "isguowai", DbType = "tinyint(4)")]
		public sbyte? IsGuOwAi
		{
			get
			{
				return _isGuOwAi;
			}
			set
			{
				if (value != _isGuOwAi)
				{
					_isGuOwAi = value;
					OnPropertyChanged("IsGuOwAi");
				}
			}
		}

		#endregion

		#region sbyte? IsHeZUO

		private sbyte? _isHeZuo;
		[DebuggerNonUserCode]
		[Column(Storage = "_isHeZuo", Name = "ishezuo", DbType = "tinyint(4)")]
		public sbyte? IsHeZUO
		{
			get
			{
				return _isHeZuo;
			}
			set
			{
				if (value != _isHeZuo)
				{
					_isHeZuo = value;
					OnPropertyChanged("IsHeZUO");
				}
			}
		}

		#endregion

		#region sbyte? IsSanJU

		private sbyte? _isSanJu;
		[DebuggerNonUserCode]
		[Column(Storage = "_isSanJu", Name = "issanju", DbType = "tinyint(4)")]
		public sbyte? IsSanJU
		{
			get
			{
				return _isSanJu;
			}
			set
			{
				if (value != _isSanJu)
				{
					_isSanJu = value;
					OnPropertyChanged("IsSanJU");
				}
			}
		}

		#endregion

		#region sbyte? IsWuJU

		private sbyte? _isWuJu;
		[DebuggerNonUserCode]
		[Column(Storage = "_isWuJu", Name = "iswuju", DbType = "tinyint(4)")]
		public sbyte? IsWuJU
		{
			get
			{
				return _isWuJu;
			}
			set
			{
				if (value != _isWuJu)
				{
					_isWuJu = value;
					OnPropertyChanged("IsWuJU");
				}
			}
		}

		#endregion

		#region string LG

		private string _lg;
		[DebuggerNonUserCode]
		[Column(Storage = "_lg", Name = "lg", DbType = "varchar(10)")]
		public string LG
		{
			get
			{
				return _lg;
			}
			set
			{
				if (value != _lg)
				{
					_lg = value;
					OnPropertyChanged("LG");
				}
			}
		}

		#endregion

		#region int? LGYear

		private int? _lgyEar;
		[DebuggerNonUserCode]
		[Column(Storage = "_lgyEar", Name = "lg_year", DbType = "int")]
		public int? LGYear
		{
			get
			{
				return _lgyEar;
			}
			set
			{
				if (value != _lgyEar)
				{
					_lgyEar = value;
					OnPropertyChanged("LGYear");
				}
			}
		}

		#endregion

		#region string MAd

		private string _maD;
		[DebuggerNonUserCode]
		[Column(Storage = "_maD", Name = "m_ad", DbType = "varchar(8)")]
		public string MAd
		{
			get
			{
				return _maD;
			}
			set
			{
				if (value != _maD)
				{
					_maD = value;
					OnPropertyChanged("MAd");
				}
			}
		}

		#endregion

		#region string OpD

		private string _opD;
		[DebuggerNonUserCode]
		[Column(Storage = "_opD", Name = "opd", DbType = "varchar(8)")]
		public string OpD
		{
			get
			{
				return _opD;
			}
			set
			{
				if (value != _opD)
				{
					_opD = value;
					OnPropertyChanged("OpD");
				}
			}
		}

		#endregion

		#region int? OpDy

		private int? _opDy;
		[DebuggerNonUserCode]
		[Column(Storage = "_opDy", Name = "opdy", DbType = "int")]
		public int? OpDy
		{
			get
			{
				return _opDy;
			}
			set
			{
				if (value != _opDy)
				{
					_opDy = value;
					OnPropertyChanged("OpDy");
				}
			}
		}

		#endregion

		#region sbyte? PaSum

		private sbyte? _paSum;
		[DebuggerNonUserCode]
		[Column(Storage = "_paSum", Name = "pa_sum", DbType = "tinyint(4)")]
		public sbyte? PaSum
		{
			get
			{
				return _paSum;
			}
			set
			{
				if (value != _paSum)
				{
					_paSum = value;
					OnPropertyChanged("PaSum");
				}
			}
		}

		#endregion

		#region string PcTAd

		private string _pcTaD;
		[DebuggerNonUserCode]
		[Column(Storage = "_pcTaD", Name = "pct_ad", DbType = "varchar(8)")]
		public string PcTAd
		{
			get
			{
				return _pcTaD;
			}
			set
			{
				if (value != _pcTaD)
				{
					_pcTaD = value;
					OnPropertyChanged("PcTAd");
				}
			}
		}

		#endregion

		#region string PcTAn

		private string _pcTaN;
		[DebuggerNonUserCode]
		[Column(Storage = "_pcTaN", Name = "pct_an", DbType = "varchar(25)")]
		public string PcTAn
		{
			get
			{
				return _pcTaN;
			}
			set
			{
				if (value != _pcTaN)
				{
					_pcTaN = value;
					OnPropertyChanged("PcTAn");
				}
			}
		}

		#endregion

		#region string PcTIn

		private string _pcTiN;
		[DebuggerNonUserCode]
		[Column(Storage = "_pcTiN", Name = "pct_in", DbType = "varchar(8)")]
		public string PcTIn
		{
			get
			{
				return _pcTiN;
			}
			set
			{
				if (value != _pcTiN)
				{
					_pcTiN = value;
					OnPropertyChanged("PcTIn");
				}
			}
		}

		#endregion

		#region string PcTPD

		private string _pcTpd;
		[DebuggerNonUserCode]
		[Column(Storage = "_pcTpd", Name = "pct_pd", DbType = "varchar(8)")]
		public string PcTPD
		{
			get
			{
				return _pcTpd;
			}
			set
			{
				if (value != _pcTpd)
				{
					_pcTpd = value;
					OnPropertyChanged("PcTPD");
				}
			}
		}

		#endregion

		#region string PcTPN

		private string _pcTpn;
		[DebuggerNonUserCode]
		[Column(Storage = "_pcTpn", Name = "pct_pn", DbType = "varchar(25)")]
		public string PcTPN
		{
			get
			{
				return _pcTpn;
			}
			set
			{
				if (value != _pcTpn)
				{
					_pcTpn = value;
					OnPropertyChanged("PcTPN");
				}
			}
		}

		#endregion

		#region string PD

		private string _pd;
		[DebuggerNonUserCode]
		[Column(Storage = "_pd", Name = "pd", DbType = "varchar(8)")]
		public string PD
		{
			get
			{
				return _pd;
			}
			set
			{
				if (value != _pd)
				{
					_pd = value;
					OnPropertyChanged("PD");
				}
			}
		}

		#endregion

		#region int? PDy

		private int? _pdY;
		[DebuggerNonUserCode]
		[Column(Storage = "_pdY", Name = "pdy", DbType = "int")]
		public int? PDy
		{
			get
			{
				return _pdY;
			}
			set
			{
				if (value != _pdY)
				{
					_pdY = value;
					OnPropertyChanged("PDy");
				}
			}
		}

		#endregion

		#region sbyte? PDyDef

		private sbyte? _pdYDef;
		[DebuggerNonUserCode]
		[Column(Storage = "_pdYDef", Name = "pdy_def", DbType = "tinyint(4)")]
		public sbyte? PDyDef
		{
			get
			{
				return _pdYDef;
			}
			set
			{
				if (value != _pdYDef)
				{
					_pdYDef = value;
					OnPropertyChanged("PDyDef");
				}
			}
		}

		#endregion

		#region int? PiCSum

		private int? _piCsUm;
		[DebuggerNonUserCode]
		[Column(Storage = "_piCsUm", Name = "pic_sum", DbType = "int")]
		public int? PiCSum
		{
			get
			{
				return _piCsUm;
			}
			set
			{
				if (value != _piCsUm)
				{
					_piCsUm = value;
					OnPropertyChanged("PiCSum");
				}
			}
		}

		#endregion

		#region string PN

		private string _pn;
		[DebuggerNonUserCode]
		[Column(Storage = "_pn", Name = "pn", DbType = "varchar(25)")]
		public string PN
		{
			get
			{
				return _pn;
			}
			set
			{
				if (value != _pn)
				{
					_pn = value;
					OnPropertyChanged("PN");
				}
			}
		}

		#endregion

		#region string QUXian

		private string _quxIan;
		[DebuggerNonUserCode]
		[Column(Storage = "_quxIan", Name = "quxian", DbType = "varchar(20)")]
		public string QUXian
		{
			get
			{
				return _quxIan;
			}
			set
			{
				if (value != _quxIan)
				{
					_quxIan = value;
					OnPropertyChanged("QUXian");
				}
			}
		}

		#endregion

		#region string QUYU

		private string _quyu;
		[DebuggerNonUserCode]
		[Column(Storage = "_quyu", Name = "quyu", DbType = "varchar(30)")]
		public string QUYU
		{
			get
			{
				return _quyu;
			}
			set
			{
				if (value != _quyu)
				{
					_quyu = value;
					OnPropertyChanged("QUYU");
				}
			}
		}

		#endregion

		#region int? SCzQ

		private int? _scZQ;
		[DebuggerNonUserCode]
		[Column(Storage = "_scZQ", Name = "sczq", DbType = "int(255)")]
		public int? SCzQ
		{
			get
			{
				return _scZQ;
			}
			set
			{
				if (value != _scZQ)
				{
					_scZQ = value;
					OnPropertyChanged("SCzQ");
				}
			}
		}

		#endregion

		#region string ShEng

		private string _shEng;
		[DebuggerNonUserCode]
		[Column(Storage = "_shEng", Name = "sheng", DbType = "varchar(20)")]
		public string ShEng
		{
			get
			{
				return _shEng;
			}
			set
			{
				if (value != _shEng)
				{
					_shEng = value;
					OnPropertyChanged("ShEng");
				}
			}
		}

		#endregion

		#region string ShEng1

		private string _shEng1;
		[DebuggerNonUserCode]
		[Column(Storage = "_shEng1", Name = "sheng1", DbType = "varchar(20)")]
		public string ShEng1
		{
			get
			{
				return _shEng1;
			}
			set
			{
				if (value != _shEng1)
				{
					_shEng1 = value;
					OnPropertyChanged("ShEng1");
				}
			}
		}

		#endregion

		#region string ShI

		private string _shI;
		[DebuggerNonUserCode]
		[Column(Storage = "_shI", Name = "shi", DbType = "varchar(20)")]
		public string ShI
		{
			get
			{
				return _shI;
			}
			set
			{
				if (value != _shI)
				{
					_shI = value;
					OnPropertyChanged("ShI");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(25)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region string Type

		private string _type;
		[DebuggerNonUserCode]
		[Column(Storage = "_type", Name = "type", DbType = "varchar(8)")]
		public string Type
		{
			get
			{
				return _type;
			}
			set
			{
				if (value != _type)
				{
					_type = value;
					OnPropertyChanged("Type");
				}
			}
		}

		#endregion

		#region string Type1

		private string _type1;
		[DebuggerNonUserCode]
		[Column(Storage = "_type1", Name = "type1", DbType = "varchar(8)")]
		public string Type1
		{
			get
			{
				return _type1;
			}
			set
			{
				if (value != _type1)
				{
					_type1 = value;
					OnPropertyChanged("Type1");
				}
			}
		}

		#endregion

		#region sbyte? YZSum

		private sbyte? _yzsUm;
		[DebuggerNonUserCode]
		[Column(Storage = "_yzsUm", Name = "yz_sum", DbType = "tinyint(4)")]
		public sbyte? YZSum
		{
			get
			{
				return _yzsUm;
			}
			set
			{
				if (value != _yzsUm)
				{
					_yzsUm = value;
					OnPropertyChanged("YZSum");
				}
			}
		}

		#endregion

		#region string ZHoU

		private string _zhOU;
		[DebuggerNonUserCode]
		[Column(Storage = "_zhOU", Name = "zhou", DbType = "varchar(8)")]
		public string ZHoU
		{
			get
			{
				return _zhOU;
			}
			set
			{
				if (value != _zhOU)
				{
					_zhOU = value;
					OnPropertyChanged("ZHoU");
				}
			}
		}

		#endregion

		#region int? ZTID

		private int? _ztid;
		[DebuggerNonUserCode]
		[Column(Storage = "_ztid", Name = "ztid", DbType = "int")]
		public int? ZTID
		{
			get
			{
				return _ztid;
			}
			set
			{
				if (value != _ztid)
				{
					_ztid = value;
					OnPropertyChanged("ZTID");
				}
			}
		}

		#endregion

		#region ctor

		public STDT()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_ec")]
	public partial class STEc : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Ec

		private string _ec;
		[DebuggerNonUserCode]
		[Column(Storage = "_ec", Name = "ec", DbType = "varchar(25)")]
		public string Ec
		{
			get
			{
				return _ec;
			}
			set
			{
				if (value != _ec)
				{
					_ec = value;
					OnPropertyChanged("Ec");
				}
			}
		}

		#endregion

		#region string Ec1

		private string _ec1;
		[DebuggerNonUserCode]
		[Column(Storage = "_ec1", Name = "ec1", DbType = "varchar(1)")]
		public string Ec1
		{
			get
			{
				return _ec1;
			}
			set
			{
				if (value != _ec1)
				{
					_ec1 = value;
					OnPropertyChanged("Ec1");
				}
			}
		}

		#endregion

		#region string Ec3

		private string _ec3;
		[DebuggerNonUserCode]
		[Column(Storage = "_ec3", Name = "ec3", DbType = "varchar(3)")]
		public string Ec3
		{
			get
			{
				return _ec3;
			}
			set
			{
				if (value != _ec3)
				{
					_ec3 = value;
					OnPropertyChanged("Ec3");
				}
			}
		}

		#endregion

		#region string Ec4

		private string _ec4;
		[DebuggerNonUserCode]
		[Column(Storage = "_ec4", Name = "ec4", DbType = "varchar(4)")]
		public string Ec4
		{
			get
			{
				return _ec4;
			}
			set
			{
				if (value != _ec4)
				{
					_ec4 = value;
					OnPropertyChanged("Ec4");
				}
			}
		}

		#endregion

		#region string Ec7

		private string _ec7;
		[DebuggerNonUserCode]
		[Column(Storage = "_ec7", Name = "ec7", DbType = "varchar(7)")]
		public string Ec7
		{
			get
			{
				return _ec7;
			}
			set
			{
				if (value != _ec7)
				{
					_ec7 = value;
					OnPropertyChanged("Ec7");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string Sid

		private string _sid;
		[DebuggerNonUserCode]
		[Column(Storage = "_sid", Name = "Sid", DbType = "varchar(25)")]
		public string Sid
		{
			get
			{
				return _sid;
			}
			set
			{
				if (value != _sid)
				{
					_sid = value;
					OnPropertyChanged("Sid");
				}
			}
		}

		#endregion

		#region sbyte? Sort

		private sbyte? _sort;
		[DebuggerNonUserCode]
		[Column(Storage = "_sort", Name = "sort", DbType = "tinyint(1)")]
		public sbyte? Sort
		{
			get
			{
				return _sort;
			}
			set
			{
				if (value != _sort)
				{
					_sort = value;
					OnPropertyChanged("Sort");
				}
			}
		}

		#endregion

		#region ctor

		public STEc()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_fml")]
	public partial class STFML : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int? FMLid

		private int? _fmlID;
		[DebuggerNonUserCode]
		[Column(Storage = "_fmlID", Name = "fmlid", DbType = "int")]
		public int? FMLid
		{
			get
			{
				return _fmlID;
			}
			set
			{
				if (value != _fmlID)
				{
					_fmlID = value;
					OnPropertyChanged("FMLid");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string PN

		private string _pn;
		[DebuggerNonUserCode]
		[Column(Storage = "_pn", Name = "pn", DbType = "varchar(25)")]
		public string PN
		{
			get
			{
				return _pn;
			}
			set
			{
				if (value != _pn)
				{
					_pn = value;
					OnPropertyChanged("PN");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(25)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region ctor

		public STFML()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_ipc")]
	public partial class STIpc : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string Ipc

		private string _ipc;
		[DebuggerNonUserCode]
		[Column(Storage = "_ipc", Name = "ipc", DbType = "varchar(20)")]
		public string Ipc
		{
			get
			{
				return _ipc;
			}
			set
			{
				if (value != _ipc)
				{
					_ipc = value;
					OnPropertyChanged("Ipc");
				}
			}
		}

		#endregion

		#region string Ipc1

		private string _ipc1;
		[DebuggerNonUserCode]
		[Column(Storage = "_ipc1", Name = "ipc1", DbType = "char(1)")]
		public string Ipc1
		{
			get
			{
				return _ipc1;
			}
			set
			{
				if (value != _ipc1)
				{
					_ipc1 = value;
					OnPropertyChanged("Ipc1");
				}
			}
		}

		#endregion

		#region string Ipc3

		private string _ipc3;
		[DebuggerNonUserCode]
		[Column(Storage = "_ipc3", Name = "ipc3", DbType = "varchar(3)")]
		public string Ipc3
		{
			get
			{
				return _ipc3;
			}
			set
			{
				if (value != _ipc3)
				{
					_ipc3 = value;
					OnPropertyChanged("Ipc3");
				}
			}
		}

		#endregion

		#region string Ipc4

		private string _ipc4;
		[DebuggerNonUserCode]
		[Column(Storage = "_ipc4", Name = "ipc4", DbType = "varchar(5)")]
		public string Ipc4
		{
			get
			{
				return _ipc4;
			}
			set
			{
				if (value != _ipc4)
				{
					_ipc4 = value;
					OnPropertyChanged("Ipc4");
				}
			}
		}

		#endregion

		#region string Ipc7

		private string _ipc7;
		[DebuggerNonUserCode]
		[Column(Storage = "_ipc7", Name = "ipc7", DbType = "varchar(7)")]
		public string Ipc7
		{
			get
			{
				return _ipc7;
			}
			set
			{
				if (value != _ipc7)
				{
					_ipc7 = value;
					OnPropertyChanged("Ipc7");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(25)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region sbyte? Sort

		private sbyte? _sort;
		[DebuggerNonUserCode]
		[Column(Storage = "_sort", Name = "sort", DbType = "tinyint(4)")]
		public sbyte? Sort
		{
			get
			{
				return _sort;
			}
			set
			{
				if (value != _sort)
				{
					_sort = value;
					OnPropertyChanged("Sort");
				}
			}
		}

		#endregion

		#region ctor

		public STIpc()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_iv")]
	public partial class STIV : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string IV

		private string _iv;
		[DebuggerNonUserCode]
		[Column(Storage = "_iv", Name = "iv", DbType = "varchar(80)")]
		public string IV
		{
			get
			{
				return _iv;
			}
			set
			{
				if (value != _iv)
				{
					_iv = value;
					OnPropertyChanged("IV");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(25)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region sbyte? Sort

		private sbyte? _sort;
		[DebuggerNonUserCode]
		[Column(Storage = "_sort", Name = "sort", DbType = "tinyint(4)")]
		public sbyte? Sort
		{
			get
			{
				return _sort;
			}
			set
			{
				if (value != _sort)
				{
					_sort = value;
					OnPropertyChanged("Sort");
				}
			}
		}

		#endregion

		#region ctor

		public STIV()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_pa")]
	public partial class STPa : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string CPY

		private string _cpy;
		[DebuggerNonUserCode]
		[Column(Storage = "_cpy", Name = "cpy", DbType = "varchar(20)")]
		public string CPY
		{
			get
			{
				return _cpy;
			}
			set
			{
				if (value != _cpy)
				{
					_cpy = value;
					OnPropertyChanged("CPY");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string Pa

		private string _pa;
		[DebuggerNonUserCode]
		[Column(Storage = "_pa", Name = "pa", DbType = "varchar(80)")]
		public string Pa
		{
			get
			{
				return _pa;
			}
			set
			{
				if (value != _pa)
				{
					_pa = value;
					OnPropertyChanged("Pa");
				}
			}
		}

		#endregion

		#region string PaType

		private string _paType;
		[DebuggerNonUserCode]
		[Column(Storage = "_paType", Name = "pa_type", DbType = "varchar(8)")]
		public string PaType
		{
			get
			{
				return _paType;
			}
			set
			{
				if (value != _paType)
				{
					_paType = value;
					OnPropertyChanged("PaType");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(25)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region sbyte? Sort

		private sbyte? _sort;
		[DebuggerNonUserCode]
		[Column(Storage = "_sort", Name = "sort", DbType = "tinyint(4)")]
		public sbyte? Sort
		{
			get
			{
				return _sort;
			}
			set
			{
				if (value != _sort)
				{
					_sort = value;
					OnPropertyChanged("Sort");
				}
			}
		}

		#endregion

		#region ctor

		public STPa()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_pns")]
	public partial class STPNS : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string PD

		private string _pd;
		[DebuggerNonUserCode]
		[Column(Storage = "_pd", Name = "pd", DbType = "varchar(8)")]
		public string PD
		{
			get
			{
				return _pd;
			}
			set
			{
				if (value != _pd)
				{
					_pd = value;
					OnPropertyChanged("PD");
				}
			}
		}

		#endregion

		#region string PDy

		private string _pdY;
		[DebuggerNonUserCode]
		[Column(Storage = "_pdY", Name = "pdy", DbType = "varchar(4)")]
		public string PDy
		{
			get
			{
				return _pdY;
			}
			set
			{
				if (value != _pdY)
				{
					_pdY = value;
					OnPropertyChanged("PDy");
				}
			}
		}

		#endregion

		#region string PN

		private string _pn;
		[DebuggerNonUserCode]
		[Column(Storage = "_pn", Name = "pn", DbType = "varchar(25)")]
		public string PN
		{
			get
			{
				return _pn;
			}
			set
			{
				if (value != _pn)
				{
					_pn = value;
					OnPropertyChanged("PN");
				}
			}
		}

		#endregion

		#region string PNGJ

		private string _pngj;
		[DebuggerNonUserCode]
		[Column(Storage = "_pngj", Name = "pn_gj", DbType = "varchar(2)")]
		public string PNGJ
		{
			get
			{
				return _pngj;
			}
			set
			{
				if (value != _pngj)
				{
					_pngj = value;
					OnPropertyChanged("PNGJ");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(25)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region sbyte? Sort

		private sbyte? _sort;
		[DebuggerNonUserCode]
		[Column(Storage = "_sort", Name = "sort", DbType = "tinyint(4)")]
		public sbyte? Sort
		{
			get
			{
				return _sort;
			}
			set
			{
				if (value != _sort)
				{
					_sort = value;
					OnPropertyChanged("Sort");
				}
			}
		}

		#endregion

		#region ctor

		public STPNS()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_pr")]
	public partial class STPR : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Ad

		private string _ad;
		[DebuggerNonUserCode]
		[Column(Storage = "_ad", Name = "ad", DbType = "varchar(8)")]
		public string Ad
		{
			get
			{
				return _ad;
			}
			set
			{
				if (value != _ad)
				{
					_ad = value;
					OnPropertyChanged("Ad");
				}
			}
		}

		#endregion

		#region string An

		private string _an;
		[DebuggerNonUserCode]
		[Column(Storage = "_an", Name = "an", DbType = "varchar(25)")]
		public string An
		{
			get
			{
				return _an;
			}
			set
			{
				if (value != _an)
				{
					_an = value;
					OnPropertyChanged("An");
				}
			}
		}

		#endregion

		#region string GJ

		private string _gj;
		[DebuggerNonUserCode]
		[Column(Storage = "_gj", Name = "gj", DbType = "varchar(25)")]
		public string GJ
		{
			get
			{
				return _gj;
			}
			set
			{
				if (value != _gj)
				{
					_gj = value;
					OnPropertyChanged("GJ");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string SiD

		private string _siD;
		[DebuggerNonUserCode]
		[Column(Storage = "_siD", Name = "sid", DbType = "varchar(25)")]
		public string SiD
		{
			get
			{
				return _siD;
			}
			set
			{
				if (value != _siD)
				{
					_siD = value;
					OnPropertyChanged("SiD");
				}
			}
		}

		#endregion

		#region sbyte? Sort

		private sbyte? _sort;
		[DebuggerNonUserCode]
		[Column(Storage = "_sort", Name = "sort", DbType = "tinyint(4)")]
		public sbyte? Sort
		{
			get
			{
				return _sort;
			}
			set
			{
				if (value != _sort)
				{
					_sort = value;
					OnPropertyChanged("Sort");
				}
			}
		}

		#endregion

		#region ctor

		public STPR()
		{
		}

		#endregion

	}

	[Table(Name = "ztst.st_ztlist")]
	public partial class STZTList : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region DateTime CreateTime

		private DateTime _createTime;
		[DebuggerNonUserCode]
		[Column(Storage = "_createTime", Name = "createtime", DbType = "datetime", IsPrimaryKey = true, CanBeNull = false)]
		public DateTime CreateTime
		{
			get
			{
				return _createTime;
			}
			set
			{
				if (value != _createTime)
				{
					_createTime = value;
					OnPropertyChanged("CreateTime");
				}
			}
		}

		#endregion

		#region int? CreateUserID

		private int? _createUserID;
		[DebuggerNonUserCode]
		[Column(Storage = "_createUserID", Name = "createuserid", DbType = "int")]
		public int? CreateUserID
		{
			get
			{
				return _createUserID;
			}
			set
			{
				if (value != _createUserID)
				{
					_createUserID = value;
					OnPropertyChanged("CreateUserID");
				}
			}
		}

		#endregion

		#region string DbType

		private string _dbType;
		[DebuggerNonUserCode]
		[Column(Storage = "_dbType", Name = "dbtype", DbType = "varchar(10)")]
		public string DbType
		{
			get
			{
				return _dbType;
			}
			set
			{
				if (value != _dbType)
				{
					_dbType = value;
					OnPropertyChanged("DbType");
				}
			}
		}

		#endregion

		#region string Des

		private string _des;
		[DebuggerNonUserCode]
		[Column(Storage = "_des", Name = "des", DbType = "varchar(255)")]
		public string Des
		{
			get
			{
				return _des;
			}
			set
			{
				if (value != _des)
				{
					_des = value;
					OnPropertyChanged("Des");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region sbyte? IsDel

		private sbyte? _isDel;
		[DebuggerNonUserCode]
		[Column(Storage = "_isDel", Name = "isdel", DbType = "tinyint(1)")]
		public sbyte? IsDel
		{
			get
			{
				return _isDel;
			}
			set
			{
				if (value != _isDel)
				{
					_isDel = value;
					OnPropertyChanged("IsDel");
				}
			}
		}

		#endregion

		#region string Name

		private string _name;
		[DebuggerNonUserCode]
		[Column(Storage = "_name", Name = "name", DbType = "varchar(100)")]
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value != _name)
				{
					_name = value;
					OnPropertyChanged("Name");
				}
			}
		}

		#endregion

		#region ctor

		public STZTList()
		{
		}

		#endregion

	}
}
