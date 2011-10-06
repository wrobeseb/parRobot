using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Text;

namespace PBizBot.Model
{
    using Enum;
    using Common;

    [Table(Name="oponent_history")]
    public class OponentHistory
    {
        private int m_id;
        private int m_oponentId;
        private OponentHistoryType m_type;
        private object m_oldValue;
        private object m_newValue;
        private DateTime m_changeDt;

        [Column(Name="id", 
                Storage="m_id", 
                IsDbGenerated=true, 
                IsPrimaryKey=true, 
                DbType="Int NOT NULL IDENTITY")]
        public int Id
        {
            get { return this.m_id; }
            set { this.m_id = value; }
        }

        [Column(Name = "oponent_id",
                Storage = "m_oponentId",
                DbType = "Int NOT NULL")]
        public int OponentId
        {
            get { return this.m_oponentId; }
            set { this.m_oponentId = value; }
        }

        [Column(Name="type", Storage="m_type", DbType="PBizBot.Enum.OponentHistoryType")]
        public OponentHistoryType Type
        {
            get { return this.m_type; }
            set { this.m_type = value; }
        }

        [Column(Name="old_value", Storage = "m_oldValue", DbType="NVarChar(255)")]
        public object OldValue
        {
            get { return this.m_oldValue; }
            set { this.m_oldValue = value; }
        }

        [Column(Name = "new_value", Storage = "m_newValue", DbType = "NVarChar(255)")]
        public object NewValue
        {
            get { return this.m_newValue; }
            set { this.m_newValue = value; }
        }

        [Column(Name = "change_dt", Storage = "m_changeDt", DbType = "DATE")]
        public DateTime ChangeDt
        {
            get { return this.m_changeDt; }
            set { this.m_changeDt = value; }
        }
    }
}
