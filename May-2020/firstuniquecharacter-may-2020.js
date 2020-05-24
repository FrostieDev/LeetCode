/**
 * @param {string} s
 * @return {number}
 */
var firstUniqChar = function (s) {
    let strMap = new Map([]);
    for (let i = 0; i < s.length; i++) {
        let currentChar = s.charAt(i);
        if (strMap.has(currentChar)) {
            strMap.set(currentChar, 1 + strMap.get(currentChar));
        } else {
            strMap.set(currentChar, 1);
        }
    }

    for (let i = 0; i < s.length; i++) {
        let val = strMap.get(s.charAt(i));
        if (val == 1) {
            return i;
        }
    }
    return -1;
};