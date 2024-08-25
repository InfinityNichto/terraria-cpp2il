using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x200009E")]
	public enum RuntimeInitializeLoadType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400034B")]
		AfterSceneLoad,
		[global::Cpp2ILInjected.Token(Token = "0x400034C")]
		BeforeSceneLoad,
		[global::Cpp2ILInjected.Token(Token = "0x400034D")]
		AfterAssembliesLoaded,
		[global::Cpp2ILInjected.Token(Token = "0x400034E")]
		BeforeSplashScreen,
		[global::Cpp2ILInjected.Token(Token = "0x400034F")]
		SubsystemRegistration
	}
}
