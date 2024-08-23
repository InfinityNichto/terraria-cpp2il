using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000AD RID: 173
	[global::Cpp2ILInjected.Token(Token = "0x20000DD")]
	[global::System.Serializable]
	public class MissingMethodException : global::System.MissingMemberException
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x00015B36 File Offset: 0x00013D36
		[global::Cpp2ILInjected.Token(Token = "0x600083A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C373C4", Offset = "0x1C373C4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMemberException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MissingMethodException()
		{
			throw null;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00015B39 File Offset: 0x00013D39
		[global::Cpp2ILInjected.Token(Token = "0x600083B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37420", Offset = "0x1C37420", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.MethodBase[]),
			typeof(ref object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[]),
			typeof(ref object)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(object[]),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMemberException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public MissingMethodException(string message)
		{
			throw null;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00015B3C File Offset: 0x00013D3C
		[global::Cpp2ILInjected.Token(Token = "0x600083C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37444", Offset = "0x1C37444", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object),
			typeof(object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "StoreRemoteField", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMemberException), Member = ".ctor", ReturnType = typeof(void))]
		public MissingMethodException(string className, string methodName)
		{
			throw null;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00015B3F File Offset: 0x00013D3F
		[global::Cpp2ILInjected.Token(Token = "0x600083D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37470", Offset = "0x1C37470", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMemberException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected MissingMethodException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00015B42 File Offset: 0x00013D42
		[global::Cpp2ILInjected.Token(Token = "0x17000092")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x600083E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C37478", Offset = "0x1C37478", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMemberException), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}
	}
}
