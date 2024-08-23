using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200008F RID: 143
	[global::Cpp2ILInjected.Token(Token = "0x200009D")]
	internal class AttributeHelperEngine
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x00002581 File Offset: 0x00000781
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60002B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F79838", Offset = "0x1F79838", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static Type GetParentTypeDisallowingMultipleInclusion(Type type)
		{
			throw null;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002584 File Offset: 0x00000784
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60002B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F79938", Offset = "0x1F79938", Length = "0x3E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static Type[] GetRequiredComponents(Type klass)
		{
			throw null;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002587 File Offset: 0x00000787
		[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F79D18", Offset = "0x1F79D18", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AttributeHelperEngine), Member = "CheckIsEditorScript", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static int GetExecuteMode(Type klass)
		{
			throw null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000258A File Offset: 0x0000078A
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60002B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F79E1C", Offset = "0x1F79E1C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeHelperEngine), Member = "GetExecuteMode", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static int CheckIsEditorScript(Type klass)
		{
			throw null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000258D File Offset: 0x0000078D
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60002B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F79EFC", Offset = "0x1F79EFC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeHelperEngine), Member = "GetCustomAttributeOfType", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(Type) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static int GetDefaultExecutionOrderFor(Type klass)
		{
			throw null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002590 File Offset: 0x00000790
		[global::Cpp2ILInjected.Token(Token = "0x60002B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x15758A4", Offset = "0x15758A4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AttributeHelperEngine), Member = "GetDefaultExecutionOrderFor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static T GetCustomAttributeOfType<T>(Type klass) where T : Attribute
		{
			throw null;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002593 File Offset: 0x00000793
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F79F7C", Offset = "0x1F79F7C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static AttributeHelperEngine()
		{
			throw null;
		}

		// Token: 0x04000317 RID: 791
		[global::Cpp2ILInjected.Token(Token = "0x4000347")]
		public static DisallowMultipleComponent[] _disallowMultipleComponentArray;

		// Token: 0x04000318 RID: 792
		[global::Cpp2ILInjected.Token(Token = "0x4000348")]
		public static ExecuteInEditMode[] _executeInEditModeArray;

		// Token: 0x04000319 RID: 793
		[global::Cpp2ILInjected.Token(Token = "0x4000349")]
		public static RequireComponent[] _requireComponentArray;
	}
}
