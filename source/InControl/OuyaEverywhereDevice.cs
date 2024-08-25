using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000044")]
	public class OuyaEverywhereDevice : InputDevice
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600035C")]
		[global::Cpp2ILInjected.Address(RVA = "0x199D838", Offset = "0x199D838", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void BeforeAttach()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600035D")]
		[global::Cpp2ILInjected.Address(RVA = "0x199D83C", Offset = "0x199D83C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Update(ulong updateTick, float deltaTime)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
		private const float LowerDeadZone = 0.2f;

		[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
		private const float UpperDeadZone = 0.9f;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private int <DeviceIndex>k__BackingField;
	}
}
