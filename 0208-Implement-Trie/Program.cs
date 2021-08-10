using System;

namespace _0208_Implement_Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            var s1 = trie.Search("apple");   // return True
            var s2 = trie.Search("app");     // return False
            var s3 = trie.StartsWith("app"); // return True
            trie.Insert("app");
            var s4 = trie.Search("app");     // return True
        }
    }

    public class Trie
    {
        private readonly TrieNode root;

        /** Initialize your data structure here. */
        public Trie()
        {
            root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            if (string.IsNullOrEmpty(word)) 
                return;
            var curr = root;
            foreach (var c in word)
            {
                if (curr.children[c - 'a'] == null)
                {
                    curr.children[c - 'a'] = new TrieNode();
                }
                curr = curr.children[c - 'a'];
            }
            curr.IsWord = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var curr = root;
            foreach (var c in word)
            {
                if (curr.children[c - 'a'] == null)
                    return false;
                else
                {
                    curr = curr.children[c - 'a'];
                }
            }
            return curr.IsWord;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            var curr = root;
            foreach (var c in prefix)
            {
                if (curr.children[c - 'a'] == null)
                {
                    return false;
                }
                else
                {
                    curr = curr.children[c - 'a'];
                }
            }
            return true;
        }

        private class TrieNode
        {
            public TrieNode()
            {
                IsWord = false;
                for (int i=0; i<children.Length; i++)
                {
                    children[i] = null;
                };
            }

            public bool IsWord { get; set; }

            public TrieNode[] children = new TrieNode[26];

        }


    }

}
