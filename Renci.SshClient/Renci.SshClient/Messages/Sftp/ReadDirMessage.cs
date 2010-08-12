﻿
namespace Renci.SshClient.Messages.Sftp
{
    internal class ReadDirMessage : SftpMessage
    {
        public override SftpMessageTypes SftpMessageType
        {
            get { return SftpMessageTypes.ReadDir; }
        }

        public string Handle { get; set; }

        protected override void LoadData()
        {
            base.LoadData();
            this.Handle = this.ReadString();
        }

        protected override void SaveData()
        {
            base.SaveData();
            this.Write(this.Handle);
        }
    }
}