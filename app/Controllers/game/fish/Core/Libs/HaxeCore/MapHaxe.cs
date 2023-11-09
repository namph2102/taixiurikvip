// Generated by Haxe 3.4.4

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace _Map {
	public sealed class Map_Impl_ {
		
		public static void @set<K, V>(global::haxe.IMap<K, V> this1, K key, V @value) {
			this1.@set(key, @value);
		}
		
		
		public static global::haxe.lang.Null<V> @get<K, V>(global::haxe.IMap<K, V> this1, K key) {
			return this1.@get(key);
		}
		
		
		public static bool exists<K, V>(global::haxe.IMap<K, V> this1, K key) {
			return this1.exists(key);
		}
		
		
		public static bool @remove<K, V>(global::haxe.IMap<K, V> this1, K key) {
			return this1.@remove(key);
		}
		
		
		public static object keys<K, V>(global::haxe.IMap<K, V> this1) {
			return this1.keys();
		}
		
		
		public static object iterator<K, V>(global::haxe.IMap<K, V> this1) {
			return this1.iterator();
		}
		
		
		public static string toString<K, V>(global::haxe.IMap<K, V> this1) {
			return this1.toString();
		}
		
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static V arrayWrite<K, V>(global::haxe.IMap<K, V> this1, K k, V v) {
			this1.@set(k, v);
			return v;
		}
		
		
		public static global::haxe.ds.StringMap<V> toStringMap<K, V>(global::haxe.IMap<K, V> t) {
			return new global::haxe.ds.StringMap<V>();
		}
		
		
		public static global::haxe.ds.IntMap<V> toIntMap<K, V>(global::haxe.IMap<K, V> t) {
			return new global::haxe.ds.IntMap<V>();
		}
		
		
		public static global::haxe.ds.EnumValueMap<K, V> toEnumValueMapMap<K, V>(global::haxe.IMap<K, V> t) {
			return new global::haxe.ds.EnumValueMap<K, V>();
		}
		
		
		public static global::haxe.ds.ObjectMap<K, V> toObjectMap<K, V>(global::haxe.IMap<K, V> t) {
			return new global::haxe.ds.ObjectMap<K, V>();
		}
		
		
		public static global::haxe.ds.StringMap<V> fromStringMap<V>(global::haxe.ds.StringMap<V> map) {
			return ((global::haxe.ds.StringMap<V>) (map) );
		}
		
		
		public static global::haxe.ds.IntMap<V> fromIntMap<V>(global::haxe.ds.IntMap<V> map) {
			return ((global::haxe.ds.IntMap<V>) (map) );
		}
		
		
		public static global::haxe.ds.ObjectMap<K, V> fromObjectMap<K, V>(global::haxe.ds.ObjectMap<K, V> map) {
			return ((global::haxe.ds.ObjectMap<K, V>) (map) );
		}
		
		
	}
}


