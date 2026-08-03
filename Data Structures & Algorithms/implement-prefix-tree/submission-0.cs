public class PrefixTree {

    private class TrieNode {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool isEndOfTheWord = false;
    } 
    
    private TrieNode root;

    public PrefixTree() {
        root = new TrieNode();
    }

    public void Insert(string word) {
        TrieNode current = root;

        foreach (char c in word) {
            if(!current.children.ContainsKey(c)) {
                current.children[c] = new TrieNode();
            };

            current = current.children[c];
        }

        current.isEndOfTheWord = true;
    }
    
    public bool Search(string word) {
        TrieNode current = root;

        foreach(char c in word) {
            if(!current.children.ContainsKey(c)) {
                return false;
            }
            current = current.children[c];
        }

        return current.isEndOfTheWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode current = root;

        foreach(char c in prefix) {
            if(!current.children.ContainsKey(c)) {
                return false;
            }
            current = current.children[c];
        }

        return true;
    }
}
