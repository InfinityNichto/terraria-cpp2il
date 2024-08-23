using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x0200002F RID: 47
	[global::Cpp2ILInjected.Token(Token = "0x2000031")]
	public abstract class InputDeviceManager
	{
		// Token: 0x0600024D RID: 589
		[global::Cpp2ILInjected.Token(Token = "0x600024E")]
		public abstract void Update(ulong updateTick, float deltaTime);

		// Token: 0x0600024E RID: 590 RVA: 0x00002735 File Offset: 0x00000935
		[global::Cpp2ILInjected.Token(Token = "0x600024F")]
		[global::Cpp2ILInjected.Address(RVA = "0x198AD60", Offset = "0x198AD60", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Destroy()
		{
			throw null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002738 File Offset: 0x00000938
		[global::Cpp2ILInjected.Token(Token = "0x6000250")]
		[global::Cpp2ILInjected.Address(RVA = "0x198AD64", Offset = "0x198AD64", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OuyaEverywhereDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected InputDeviceManager()
		{
			throw null;
		}

		// Token: 0x04000246 RID: 582
		[global::Cpp2ILInjected.Token(Token = "0x400024D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected readonly List<InputDevice> devices;
	}
}
