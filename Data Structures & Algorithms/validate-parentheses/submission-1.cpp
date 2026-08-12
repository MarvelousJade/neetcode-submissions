class Solution {
public:
    bool isValid(string s) {
        std::stack<char> openBracketStack;
        std::unordered_map<char, char> closeToOpen{
            {')', '('},
            {'}', '{'},
            {']', '['},
        };

        for (char c : s) {
            if (closeToOpen.count(c)) {
                if (openBracketStack.empty() || openBracketStack.top() != closeToOpen[c]) {
                    return false;
                } else {
                    openBracketStack.pop();
                }
            } else {
                openBracketStack.push(c);
            }
        }

        return openBracketStack.empty();
    }
};
