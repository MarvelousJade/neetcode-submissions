class WordDictionary {
public:
    class TrieNode {
    public:
        unordered_map<char, unique_ptr<TrieNode>> children;
        bool isEnd = false;
    };

    TrieNode root;

public:
    void addWord(const string& word) {
        TrieNode* cur = &root;

        for (char c : word) {
            auto& child = cur->children[c];

            if (!child) {
                child = make_unique<TrieNode>();
            }

            cur = child.get();
        }
        cur->isEnd = true;
    }
    
    bool search(const string& word) {
        return dfs(word, 0, root); 
    }

private:
    bool dfs(const string& word, size_t start, const TrieNode& node) const {
        const TrieNode* cur = &node;

        for (size_t i = start; i < word.size(); i++) {
            char c = word[i];
            if (c == '.') {
                for (auto& [letter, child] : cur->children) {
                    if (dfs(word, i + 1, *child)) {
                        return true; 
                    }
                }
                return false;
            }

            auto it = cur->children.find(c);

            if(it == cur->children.end()) {
                return false;
            }
            cur = it->second.get();
        }
        return cur->isEnd;
    }
};
