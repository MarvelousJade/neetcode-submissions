public class WordDictionary {
    public class TrieNode {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool isEnd = false;
    }

    private TrieNode root;

    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        var cur = root;
        foreach (char c in word) {
            if (!cur.children.ContainsKey(c)) {
                cur.children[c] = new TrieNode();
            }
            cur = cur.children[c]; 
        }
        cur.isEnd = true;
    }
    
    public bool Search(string word) {
        return Dfs(word, 0, root);
    }

    private bool Dfs(string word, int j, TrieNode node) {
        var cur = node;

        for (int i = j; i < word.Length; i++) {
            char c = word[i];
            if ( c == '.') {
                foreach (TrieNode child in cur.children.Values) {
                    if (Dfs(word, i + 1, child)) {
                        return true;
                    }
                }
                return false;
            }

            if (!cur.children.TryGetValue(c, out TrieNode? next)) {
                return false;
            }

            cur = next;
        }
    
        return cur.isEnd;
    }
}
