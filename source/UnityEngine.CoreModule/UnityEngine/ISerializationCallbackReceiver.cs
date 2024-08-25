using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200003C")]
	public interface ISerializationCallbackReceiver
	{
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000072")]
		void OnBeforeSerialize();

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000073")]
		void OnAfterDeserialize();
	}
}
