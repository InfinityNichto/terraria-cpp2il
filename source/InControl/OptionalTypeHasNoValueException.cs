using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000058 RID: 88
	[global::Cpp2ILInjected.Token(Token = "0x2000063")]
	public class OptionalTypeHasNoValueException : SystemException
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x00002D29 File Offset: 0x00000F29
		[global::Cpp2ILInjected.Token(Token = "0x6000468")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5A64", Offset = "0x19B5A64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalFloat), Member = "get_Value", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalInputDeviceDriverType), Member = "get_Value", ReturnType = typeof(InputDeviceDriverType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalInputDeviceTransportType), Member = "get_Value", ReturnType = typeof(InputDeviceTransportType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalInt16), Member = "get_Value", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalInt32), Member = "get_Value", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalUInt16), Member = "get_Value", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalUInt32), Member = "get_Value", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public OptionalTypeHasNoValueException(string message)
		{
			throw null;
		}
	}
}
