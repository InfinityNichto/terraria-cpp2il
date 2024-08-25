using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	[global::Cpp2ILInjected.Token(Token = "0x200015B")]
	[Serializable]
	internal class ArgumentCache : ISerializationCallbackReceiver
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600067E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F907C0", Offset = "0x1F907C0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		public void OnBeforeSerialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600067F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F907DC", Offset = "0x1F907DC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		public void OnAfterDeserialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000680")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F907F8", Offset = "0x1F907F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ArgumentCache()
		{
			throw null;
		}

		[FormerlySerializedAs("objectArgument")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000648")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Object m_ObjectArgument;

		[SerializeField]
		[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
		[global::Cpp2ILInjected.Token(Token = "0x4000649")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_ObjectArgumentAssemblyTypeName;

		[FormerlySerializedAs("intArgument")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400064A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_IntArgument;

		[SerializeField]
		[FormerlySerializedAs("floatArgument")]
		[global::Cpp2ILInjected.Token(Token = "0x400064B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float m_FloatArgument;

		[SerializeField]
		[FormerlySerializedAs("stringArgument")]
		[global::Cpp2ILInjected.Token(Token = "0x400064C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string m_StringArgument;

		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400064D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool m_BoolArgument;
	}
}
