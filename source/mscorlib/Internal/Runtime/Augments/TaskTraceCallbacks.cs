using System;
using Cpp2ILInjected;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000047 RID: 71
	[global::Cpp2ILInjected.Token(Token = "0x2000062")]
	internal abstract class TaskTraceCallbacks
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001CE RID: 462
		[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
		public abstract bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022A")]
			get;
		}

		// Token: 0x060001CF RID: 463
		[global::Cpp2ILInjected.Token(Token = "0x600022B")]
		public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x060001D0 RID: 464
		[global::Cpp2ILInjected.Token(Token = "0x600022C")]
		public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x060001D1 RID: 465
		[global::Cpp2ILInjected.Token(Token = "0x600022D")]
		public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x060001D2 RID: 466
		[global::Cpp2ILInjected.Token(Token = "0x600022E")]
		public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions);
	}
}
