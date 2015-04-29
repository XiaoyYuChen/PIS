'类名：SqlDbAccess 
'功能：SQL SERVER 专用的链接数据库的操作类
'作者：陈晓雨
'编写时间：2007-6-30


Imports System.Data
Imports System.Data.Sql
Imports MySql.Data.MySqlClient
Imports System.Configuration
''' <summary>
''' SQL SERVER数据库操作类
''' </summary>
''' <remarks>
''' dim strSQL = "UPDATE [TABLENAME] SET [COLNAME]=@VALUE WHERE ID=@ID"
''' dim params(1) = new MySqlParameter()
''' params(0) = MySqlParameter("@VALUE",sqldbtype.varchar,10)
''' params(1) = MySqlParameter("@id",sqldbtype.int)
''' params(0).value  = "234"
''' parmas(1).value = 123
''' try
'''     if sqldbaccess.ExecNoQuery(commandtype.text,strsql,params) != 0 then
'''     'TODO: something
'''     end if
''' catch ex as Exception
''' end try
''' 
''' </remarks>
Public Class MySqlDbAccess

#Region "字段"
    Private Shared _Connstr = System.Configuration.ConfigurationManager.ConnectionStrings("MySqlServerStr").ToString.Trim
    Private Shared parmCache As Hashtable = Hashtable.Synchronized(New Hashtable)
#End Region

#Region "属性"
    ''' <summary>
    ''' 链接字符串
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property ConnStr() As String
        Get
            Return _Connstr
        End Get
        Set(ByVal value As String)
            _Connstr = value
        End Set
    End Property
#End Region

#Region "方法"

    ''' <summary>
    ''' 得到默认的数据库链接对象
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>
    ''' e.g.:dim conn as MySqlConnection = SqlDbAccess.GetMySqlConnection()
    ''' 得到一个ODBC数据库链接对象 链接字符串为Web.Config文件中的ConnectionStrings("SqlServerConnString")节点
    ''' </remarks>
    Public Shared Function GetMySqlConnection() As MySqlConnection
        Return New MySqlConnection(_Connstr.ToString)
    End Function
    ''' <summary>
    ''' 得到链接字符串的数据库链接对象没啥用
    ''' </summary>
    ''' <remarks>
    ''' e.g.: dim conn as new MySqlConnection = SqlDbAccess.GetMySqlConnection("链接字符串...")
    '''       dim conn as new MySqlConnection("链接字符串...")
    ''' 两者一样的
    ''' </remarks>      
    ''' <param name="ConnString">一个合法的链接字符串</param>
    ''' <returns></returns>
    Public Shared Function GetMySqlConnection(ByVal ConnString As String) As MySqlConnection
        Return New MySqlConnection(ConnString)
    End Function

    ''' <summary>
    ''' 使用默认的数据库链接 执行没有返回结果集的查询  
    ''' </summary>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数数组</param>
    ''' <returns>返回所影响的行数</returns>
    ''' <remarks></remarks>
    Public Shared Function ExecNoQuery(ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As Integer
        Dim cmd As New MySqlCommand
        Using conn As New MySqlConnection(ConnStr)
            PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
            Dim val As Integer = cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            Return val
        End Using
    End Function
    ''' <summary>
    ''' 使用指定的数据库链接字符串 执行没有返回结果集的查询 
    ''' </summary>
    ''' <param name="ConnString">数据库链接字符串</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数数组</param>
    ''' <returns>返回所影响的行数</returns>
    ''' <remarks></remarks>
    Public Shared Function ExecNoQuery(ByVal ConnString As String, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As Integer
        Dim cmd As New MySqlCommand
        Using con As New MySqlConnection(ConnString)
            PreparativeCommand(cmd, con, Nothing, cmdType, cmdText, params)
            Dim val As Integer = cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            Return val
        End Using
    End Function
    ''' <summary>
    ''' 使用指定的数据库链接 执行没有返回结果集的查询 
    ''' </summary>
    ''' <param name="Conn">已存在的数据库链接对象</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数数组</param>
    ''' <returns>返回所影响的行数</returns>
    ''' <remarks></remarks>
    Public Shared Function ExecNoQuery(ByVal Conn As MySqlConnection, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As Integer
        Dim cmd As New MySqlCommand
        Dim val As Integer
        PreparativeCommand(cmd, Conn, Nothing, cmdType, cmdText, params)
        val = cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        Return val
    End Function
    ''' <summary>
    ''' 使用指定的数据库链接事务 执行没有返回结果集的查询  
    ''' </summary>
    ''' <param name="trans">已经存在的数据库事务</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数数组</param>
    ''' <returns>返回所影响的行数</returns>
    ''' <remarks></remarks>
    Public Shared Function ExecNoQuery(ByVal trans As MySqlTransaction, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As Integer
        Dim cmd As New MySqlCommand
        PreparativeCommand(cmd, trans.Connection, trans, cmdType, cmdText, params)
        Dim val As Integer = cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        Return val
    End Function

    ''' <summary>
    ''' 查询 使用默认的数据库链接 返回数据流
    ''' </summary>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>数据流</returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteReader(ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim odbcReader As MySqlDataReader
        Dim conn As New MySqlConnection(ConnStr)
        PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
        odbcReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Parameters.Clear()
        Return odbcReader
    End Function
    ''' <summary>
    ''' 查询 使用指定的数据库链接字符串 返回数据流
    ''' </summary>
    ''' <param name="ConnString">一个合法的链接字符串</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>数据流</returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteReader(ByVal ConnString As String, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim odbcReader As MySqlDataReader
        Dim conn As New MySqlConnection(ConnString)
        PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
        odbcReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Parameters.Clear()
        Return odbcReader
    End Function
    ''' <summary>
    ''' 查询 使用指定的数据库链接 返回数据流
    ''' </summary>
    ''' <param name="conn">已存在的数据库链接对象</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>数据流</returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteReader(ByVal conn As MySqlConnection, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim odbcReader As MySqlDataReader
        PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
        odbcReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Parameters.Clear()
        Return odbcReader
    End Function
    ''' <summary>
    ''' 查询 使用指定的数据库链接事务 返回数据流
    ''' </summary>
    ''' <param name="trans">已经存在的数据库事务</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>数据流</returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteReader(ByVal trans As MySqlTransaction, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim odbcReader As MySqlDataReader
        PreparativeCommand(cmd, Nothing, trans, cmdType, cmdText, params)
        odbcReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Parameters.Clear()
        Return odbcReader
    End Function



    ''' <summary>
    ''' 查询数据 使用默认的数据库链接 返回第一行的第一列
    ''' </summary>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteScalar(ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As Object
        Dim cmd As New MySqlCommand
        Using conn As New MySqlConnection(ConnStr)
            PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
            Dim val As Object = cmd.ExecuteScalar()
            cmd.Parameters.Clear()
            Return val
        End Using

    End Function
    ''' <summary>
    ''' 查询数据 使用指定的连接字符串 返回第一行的第一列
    ''' </summary>
    ''' <param name="ConnString">使用指定的连接字符串</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteScalar(ByVal ConnString As String, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As Object
        Dim cmd As New MySqlCommand
        Using conn As New MySqlConnection(ConnString)
            PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
            Dim val As Object = cmd.ExecuteScalar()
            cmd.Parameters.Clear()
            Return val
        End Using

    End Function
    ''' <summary>
    ''' 查询数据 使用指定的数据库链接 返回第一行的第一列
    ''' </summary>
    ''' <param name="conn">一个已经开启的数据库连接</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteScalar(ByVal conn As MySqlConnection, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As Object
        Dim cmd As New MySqlCommand
        PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
        Dim val As Object = cmd.ExecuteScalar()
        cmd.Parameters.Clear()
        Return val

    End Function
    ''' <summary>
    ''' 查询数据 使用指定的数据库链接事务 返回第一行的第一列
    ''' </summary>
    ''' <param name="trans">一个已经开启的事务</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteScalar(ByVal trans As MySqlTransaction, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As Object
        Dim cmd As New MySqlCommand
        PreparativeCommand(cmd, trans.Connection, trans, cmdType, cmdText, params)
        Dim val As Object = cmd.ExecuteScalar()
        cmd.Parameters.Clear()
        Return val

    End Function


    ''' <summary>
    ''' 查询数据 使用默认的数据库链接   返回查询结果集
    ''' </summary>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataSet(ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As DataSet
        Dim cmd As New MySqlCommand
        Dim ds As New DataSet
        Using conn As New MySqlConnection(ConnStr)
            PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(ds)
            cmd.Parameters.Clear()
            Return ds
        End Using
    End Function
    ''' <summary>
    ''' 查询数据 使用指定的连接字符串   返回查询结果集
    ''' </summary>
    ''' <param name="ConnString">一个合法的链接字符串</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataSet(ByVal ConnString As String, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As DataSet
        Dim cmd As New MySqlCommand
        Dim ds As New DataSet
        Using conn As New MySqlConnection(ConnString)
            PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(ds)
            cmd.Parameters.Clear()
            Return ds
        End Using
    End Function
    ''' <summary>
    ''' 查询数据 使用指定的数据库链接   返回查询结果集
    ''' </summary>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataSet(ByVal conn As MySqlConnection, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As DataSet
        Dim cmd As New MySqlCommand
        Dim ds As New DataSet
        PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
        Dim adapter As New MySqlDataAdapter(cmd)
        adapter.Fill(ds)
        cmd.Parameters.Clear()
        Return ds
    End Function
    ''' <summary>
    ''' 查询数据 使用的指定数据库链接事务 返回查询结果集
    ''' </summary>
    ''' <param name="trans">指定数据库链接事务</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataSet(ByVal trans As MySqlTransaction, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As DataSet
        Dim cmd As New MySqlCommand
        Dim ds As New DataSet
        PreparativeCommand(cmd, trans.Connection, trans, cmdType, cmdText, params)
        Dim adapter As New MySqlDataAdapter(cmd)
        adapter.Fill(ds)
        cmd.Parameters.Clear()
        Return ds
    End Function

    ''' <summary>
    ''' 查询数据 使用默认的数据库链接 返回查询结果集
    ''' </summary>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataTable(ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As DataTable
        Dim cmd As New MySqlCommand
        Dim table As New DataTable
        Using conn As New MySqlConnection(ConnStr)
            PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(table)
            cmd.Parameters.Clear()
            Return table
        End Using
    End Function
    ''' <summary>
    ''' 查询数据 使用指定的连接字符串   返回查询结果集
    ''' </summary>
    ''' <param name="ConnString">一个合法的链接字符串</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataTable(ByVal ConnString As String, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As DataTable
        Dim cmd As New MySqlCommand
        Dim table As New DataTable
        Using conn As New MySqlConnection(ConnString)
            PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(table)
            cmd.Parameters.Clear()
            Return table
        End Using
    End Function
    ''' <summary>
    ''' 查询数据 使用指定的数据库链接   返回查询结果集
    ''' </summary>
    ''' <param name="conn">一个打开的数据库连接</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataTable(ByVal conn As MySqlConnection, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As DataTable
        Dim cmd As New MySqlCommand
        Dim table As New DataTable
        PreparativeCommand(cmd, conn, Nothing, cmdType, cmdText, params)
        Dim adapter As New MySqlDataAdapter(cmd)
        adapter.Fill(table)
        cmd.Parameters.Clear()
        Return table
    End Function
    ''' <summary>
    ''' 查询数据 使用的指定数据库链接事务 返回查询结果集
    ''' </summary>
    ''' <param name="trans">一个已经开启的事务</param>
    ''' <param name="cmdType">查询类型T-SQL语句\存储过程</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="params">查询参数</param>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataTable(ByVal trans As MySqlTransaction, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray params() As MySqlParameter) As DataTable
        Dim cmd As New MySqlCommand
        Dim table As New DataTable
        PreparativeCommand(cmd, trans.Connection, trans, cmdType, cmdText, params)
        Dim adapter As New MySqlDataAdapter(cmd)
        adapter.Fill(table)
        cmd.Parameters.Clear()
        Return table
    End Function


    ''' <summary>
    ''' 为执行T-SQL语句做准备
    ''' </summary>
    ''' <param name="cmd">MySqlCommand 对象</param>
    ''' <param name="conn">数据库链接对象</param>
    ''' <param name="trans">数据库操作事务</param>
    ''' <param name="cmdType">查询类型</param>
    ''' <param name="cmdText">查询语句</param>
    ''' <param name="parms">查询需要的参数数组</param>
    ''' <remarks></remarks>
    Private Shared Sub PreparativeCommand(ByVal cmd As MySqlCommand, ByVal conn As MySqlConnection, ByVal trans As MySqlTransaction, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal ParamArray parms() As MySqlParameter)

        '如果链接没有打开 打开链接
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If

        '设置数据库链接
        cmd.Connection = conn
        '查询语句
        cmd.CommandText = cmdText
        '查询类型  T-SQL \ 存储过程
        cmd.CommandType = cmdType

        cmd.CommandTimeout = 60 * 30

        '是使用事务提交还是不使用
        If Not IsNothing(trans) Then
            cmd.Transaction = trans
        End If

        '如果查询参数不为空(给参数赋值)
        If Not IsNothing(parms) Then
            For Each par As MySqlParameter In parms
                cmd.Parameters.Add(par)
            Next
        End If
    End Sub
    ''' <summary>
    ''' 缓存查询参数
    ''' </summary>
    ''' <param name="cacheKey">名字</param>
    ''' <param name="parms">参数数组</param>
    ''' <remarks>
    ''' 保存需要缓存的参数数组
    ''' </remarks>
    Public Shared Sub CacheParameters(ByVal cacheKey As String, ByVal ParamArray parms() As MySqlParameter)
        parmCache(cacheKey) = parms
    End Sub
    ''' <summary>
    ''' 得到缓存的参数
    ''' </summary>
    ''' <param name="cacheKey">名字</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCachedParameters(ByVal cacheKey As String) As MySqlParameter()
        '判断是否保存了需要的参数
        Dim params() As MySqlParameter = CType(parmCache(cacheKey), MySqlParameter())

        '如果没有就返回nothing
        If params Is Nothing Then
            Return Nothing
        End If
        '有 已经保存过的参数
        Dim clonedParms(params.Length - 1) As MySqlParameter '从新声明跟保存的参数数组一样大小的参数数组

        '赋值
        For i As Integer = 0 To params.Length - 1
            clonedParms(i) = CType(CType(params(i), ICloneable).Clone, MySqlParameter)
        Next
        Return clonedParms
    End Function
#End Region

End Class