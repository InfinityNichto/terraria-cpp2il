using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x02000133 RID: 307
	[global::Cpp2ILInjected.Token(Token = "0x200015B")]
	[Serializable]
	internal class ArgumentCache : ISerializationCallbackReceiver
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00002E42 File Offset: 0x00001042
		[global::Cpp2ILInjected.Token(Token = "0x17000155")]
		public Object unityObjectArgument
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000678")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F90790", Offset = "0x1F90790", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00002E45 File Offset: 0x00001045
		[global::Cpp2ILInjected.Token(Token = "0x17000156")]
		public string unityObjectArgumentAssemblyTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000679")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F90798", Offset = "0x1F90798", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00002E48 File Offset: 0x00001048
		[global::Cpp2ILInjected.Token(Token = "0x17000157")]
		public int intArgument
		{
			[global::Cpp2ILInjected.Token(Token = "0x600067A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F907A0", Offset = "0x1F907A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00002E4B File Offset: 0x0000104B
		[global::Cpp2ILInjected.Token(Token = "0x17000158")]
		public float floatArgument
		{
			[global::Cpp2ILInjected.Token(Token = "0x600067B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F907A8", Offset = "0x1F907A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00002E4E File Offset: 0x0000104E
		[global::Cpp2ILInjected.Token(Token = "0x17000159")]
		public string stringArgument
		{
			[global::Cpp2ILInjected.Token(Token = "0x600067C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F907B0", Offset = "0x1F907B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00002E51 File Offset: 0x00001051
		[global::Cpp2ILInjected.Token(Token = "0x1700015A")]
		public bool boolArgument
		{
			[global::Cpp2ILInjected.Token(Token = "0x600067D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F907B8", Offset = "0x1F907B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002E54 File Offset: 0x00001054
		[global::Cpp2ILInjected.Token(Token = "0x600067E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F907C0", Offset = "0x1F907C0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		public void OnBeforeSerialize()
		{
			throw null;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002E57 File Offset: 0x00001057
		[global::Cpp2ILInjected.Token(Token = "0x600067F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F907DC", Offset = "0x1F907DC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		public void OnAfterDeserialize()
		{
			throw null;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002E5A File Offset: 0x0000105A
		[global::Cpp2ILInjected.Token(Token = "0x6000680")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F907F8", Offset = "0x1F907F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ArgumentCache()
		{
			throw null;
		}

		// Token: 0x040005F1 RID: 1521
		[FormerlySerializedAs("objectArgument")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000648")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Object m_ObjectArgument;

		// Token: 0x040005F2 RID: 1522
		[SerializeField]
		[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
		[global::Cpp2ILInjected.Token(Token = "0x4000649")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_ObjectArgumentAssemblyTypeName;

		// Token: 0x040005F3 RID: 1523
		[FormerlySerializedAs("intArgument")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400064A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_IntArgument;

		// Token: 0x040005F4 RID: 1524
		[SerializeField]
		[FormerlySerializedAs("floatArgument")]
		[global::Cpp2ILInjected.Token(Token = "0x400064B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float m_FloatArgument;

		// Token: 0x040005F5 RID: 1525
		[SerializeField]
		[FormerlySerializedAs("stringArgument")]
		[global::Cpp2ILInjected.Token(Token = "0x400064C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string m_StringArgument;

		// Token: 0x040005F6 RID: 1526
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400064D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool m_BoolArgument;
	}
}
