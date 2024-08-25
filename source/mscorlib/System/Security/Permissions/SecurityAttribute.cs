using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Permissions
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[global::System.Obsolete("CAS support is not available with Silverlight applications.")]
	[global::Cpp2ILInjected.Token(Token = "0x20002AF")]
	[global::System.Serializable]
	public abstract class SecurityAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600175B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0D7C", Offset = "0x1AF0D7C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		protected SecurityAttribute(SecurityAction action)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600175C")]
		public abstract IPermission CreatePermission();

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

		[global::Cpp2ILInjected.Token(Token = "0x4000BFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SecurityAction m_Action;

		[global::Cpp2ILInjected.Token(Token = "0x4000BFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool m_Unrestricted;
	}
}
