using System.Data;

namespace Dapper
{
    public class ParamInfo
    {
        public object Value { get; internal set; }
        public IDbDataParameter AttachedParam { get; internal set; }
        public bool CameFromTemplate { get; internal set; }
        public DbType DbType { get; internal set; }
        public string Name { get; internal set; }
        public int Size { get; internal set; }
        public ParameterDirection ParameterDirection { get; internal set; }
        public byte? Precision { get; internal set; }
        public byte? Scale { get; internal set; }
        public Action<object, DynamicParameters> OutputCallback { get; internal set; }
        public object OutputTarget { get; internal set; }
    }
}