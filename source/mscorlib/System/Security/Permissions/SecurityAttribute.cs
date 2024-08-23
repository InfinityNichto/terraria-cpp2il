using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Permissions
{
	// Token: 0x02000217 RID: 535
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[global::System.Obsolete("CAS support is not available with Silverlight applications.")]
	[global::Cpp2ILInjected.Token(Token = "0x20002AF")]
	[global::System.Serializable]
	public abstract class SecurityAttribute : global::System.Attribute
	{
		// Token: 0x0600154C RID: 5452 RVA: 0x000180E3 File Offset: 0x000162E3
		[global::Cpp2ILInjected.Token(Token = "0x600175B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0D7C", Offset = "0x1AF0D7C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		protected SecurityAttribute(SecurityAction action)
		{
			throw null;
		}

		// Token: 0x0600154D RID: 5453
		[global::Cpp2ILInjected.Token(Token = "0x600175C")]
		public abstract IPermission CreatePermission();

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x000180E6 File Offset: 0x000162E6
		[global::Cpp2ILInjected.Token(Token = "0x1700025F")]
		public bool Unrestricted
		{
			[global::Cpp2ILInjected.Token(Token = "0x600175D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF1540", Offset = "0x1AF1540", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700020A RID: 522
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x000180E9 File Offset: 0x000162E9
		[global::Cpp2ILInjected.Token(Token = "0x17000260")]
		public SecurityAction Action
		{
			[global::Cpp2ILInjected.Token(Token = "0x600175E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF1548", Offset = "0x1AF1548", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000953 RID: 2387
		[global::Cpp2ILInjected.Token(Token = "0x4000BFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SecurityAction m_Action;

		// Token: 0x04000954 RID: 2388
		[global::Cpp2ILInjected.Token(Token = "0x4000BFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool m_Unrestricted;
	}
}
