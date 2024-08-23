using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x0200003F RID: 63
	[global::Cpp2ILInjected.Token(Token = "0x2000044")]
	public class OuyaEverywhereDevice : InputDevice
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00002A3B File Offset: 0x00000C3B
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00002A3E File Offset: 0x00000C3E
		[global::Cpp2ILInjected.Token(Token = "0x17000110")]
		public int DeviceIndex
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000359")]
			[global::Cpp2ILInjected.Address(RVA = "0x199D3A4", Offset = "0x199D3A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600035A")]
			[global::Cpp2ILInjected.Address(RVA = "0x199D3AC", Offset = "0x199D3AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002A41 File Offset: 0x00000C41
		[global::Cpp2ILInjected.Token(Token = "0x600035B")]
		[global::Cpp2ILInjected.Address(RVA = "0x199D3B4", Offset = "0x199D3B4", Length = "0x484")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OuyaEverywhereDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "AddControl", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(string)
		}, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public OuyaEverywhereDevice(int deviceIndex)
		{
			throw null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002A44 File Offset: 0x00000C44
		[global::Cpp2ILInjected.Token(Token = "0x600035C")]
		[global::Cpp2ILInjected.Address(RVA = "0x199D838", Offset = "0x199D838", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void BeforeAttach()
		{
			throw null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002A47 File Offset: 0x00000C47
		[global::Cpp2ILInjected.Token(Token = "0x600035D")]
		[global::Cpp2ILInjected.Address(RVA = "0x199D83C", Offset = "0x199D83C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Update(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00002A4A File Offset: 0x00000C4A
		[global::Cpp2ILInjected.Token(Token = "0x17000111")]
		public bool IsConnected
		{
			[global::Cpp2ILInjected.Token(Token = "0x600035E")]
			[global::Cpp2ILInjected.Address(RVA = "0x199D840", Offset = "0x199D840", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002DB RID: 731
		[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
		private const float LowerDeadZone = 0.2f;

		// Token: 0x040002DC RID: 732
		[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
		private const float UpperDeadZone = 0.9f;

		// Token: 0x040002DD RID: 733
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private int <DeviceIndex>k__BackingField;
	}
}
