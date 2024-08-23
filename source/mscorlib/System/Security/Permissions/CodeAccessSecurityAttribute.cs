using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Permissions
{
	// Token: 0x02000214 RID: 532
	[global::System.Obsolete("CAS support is not available with Silverlight applications.")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20002AC")]
	[global::System.Serializable]
	public abstract class CodeAccessSecurityAttribute : SecurityAttribute
	{
		// Token: 0x0600153F RID: 5439 RVA: 0x000180BC File Offset: 0x000162BC
		[global::Cpp2ILInjected.Token(Token = "0x600174E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0D54", Offset = "0x1AF0D54", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermissionAttribute", Member = ".ctor", MemberParameters = new object[] { typeof(SecurityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermissionAttribute", Member = ".ctor", MemberParameters = new object[] { typeof(SecurityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		protected CodeAccessSecurityAttribute(SecurityAction action)
		{
			throw null;
		}
	}
}
