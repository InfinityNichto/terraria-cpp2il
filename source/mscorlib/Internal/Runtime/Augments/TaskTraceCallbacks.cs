using System;
using Cpp2ILInjected;

namespace Internal.Runtime.Augments
{
	[global::Cpp2ILInjected.Token(Token = "0x2000062")]
	internal abstract class TaskTraceCallbacks
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
		public abstract bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600022B")]
		public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		[global::Cpp2ILInjected.Token(Token = "0x600022C")]
		public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		[global::Cpp2ILInjected.Token(Token = "0x600022D")]
		public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		[global::Cpp2ILInjected.Token(Token = "0x600022E")]
		public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions);
	}
}
