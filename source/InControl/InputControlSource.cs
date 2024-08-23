using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000020 RID: 32
	[global::Cpp2ILInjected.Token(Token = "0x2000021")]
	[Serializable]
	public struct InputControlSource
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000245F File Offset: 0x0000065F
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002462 File Offset: 0x00000662
		[global::Cpp2ILInjected.Token(Token = "0x17000060")]
		public InputControlSourceType SourceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986718", Offset = "0x1986718", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600015C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986720", Offset = "0x1986720", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002465 File Offset: 0x00000665
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002468 File Offset: 0x00000668
		[global::Cpp2ILInjected.Token(Token = "0x17000061")]
		public int Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986728", Offset = "0x1986728", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600015E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986730", Offset = "0x1986730", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000246B File Offset: 0x0000066B
		[global::Cpp2ILInjected.Token(Token = "0x600015F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986738", Offset = "0x1986738", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		public InputControlSource(InputControlSourceType sourceType, int index)
		{
			throw null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000246E File Offset: 0x0000066E
		[global::Cpp2ILInjected.Token(Token = "0x6000160")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986740", Offset = "0x1986740", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public InputControlSource(KeyCode keyCode)
		{
			throw null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002471 File Offset: 0x00000671
		[global::Cpp2ILInjected.Token(Token = "0x6000161")]
		[global::Cpp2ILInjected.Address(RVA = "0x198674C", Offset = "0x198674C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControlSource), Member = "GetState", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = "GetState", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public float GetValue(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002474 File Offset: 0x00000674
		[global::Cpp2ILInjected.Token(Token = "0x6000162")]
		[global::Cpp2ILInjected.Address(RVA = "0x19867D8", Offset = "0x19867D8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControlSource), Member = "GetValue", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = "GetValue", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "IsNotZero", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool GetState(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002477 File Offset: 0x00000677
		[global::Cpp2ILInjected.Token(Token = "0x6000163")]
		[global::Cpp2ILInjected.Address(RVA = "0x19868D0", Offset = "0x19868D0", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public string ToCode()
		{
			throw null;
		}

		// Token: 0x0400013B RID: 315
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400013F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private InputControlSourceType sourceType;

		// Token: 0x0400013C RID: 316
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000140")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int index;
	}
}
