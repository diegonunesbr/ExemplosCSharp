using System.Collections.Generic;


namespace DiegoNunesCom {
	public class DefaultDictionary<TKey, TValue>: Dictionary<TKey, TValue> {
		public new TValue this[TKey key] {
			get {
				if(ContainsKey(key)) {
					return base[key];
				}
				return default(TValue);
			}
			set {
				base[key] = value;
			}
		}
	}
}
