using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	[AttributeUsage(AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	public class GUITargetAttribute : Attribute
	{
		// Token: 0x0600009B RID: 155 RVA: 0x000021BB File Offset: 0x000003BB
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600009F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C21C", Offset = "0x1F9C21C", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int GetGUITargetAttrValue(Type klass, string methodName)
		{
			throw null;
		}

		// Token: 0x04000081 RID: 129
		[global::Cpp2ILInjected.Token(Token = "0x4000088")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int displayMask;
	}
}
