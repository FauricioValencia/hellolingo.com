//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Considerate.Hellolingo.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class MailsArchive
    {
        public long Id { get; set; }
        public System.DateTime When { get; set; }
        public byte RegulationStatus { get; set; }
        public byte NotifyStatus { get; set; }
        public int FromId { get; set; }
        public byte FromStatus { get; set; }
        public int ToId { get; set; }
        public byte ToStatus { get; set; }
        public Nullable<long> ReplyToMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    
        public virtual MailRegulationStatus MailRegulationStatus { get; set; }
        public virtual MailStatus MailStatus { get; set; }
        public virtual MailStatus MailStatus1 { get; set; }
        public virtual NotifyStatus NotifyStatus1 { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
