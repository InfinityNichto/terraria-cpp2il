using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000039 RID: 57
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200003C")]
	public interface ISerializationCallbackReceiver
	{
		// Token: 0x0600006A RID: 106
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000072")]
		void OnBeforeSerialize();

		// Token: 0x0600006B RID: 107
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000073")]
		void OnAfterDeserialize();
	}
}
