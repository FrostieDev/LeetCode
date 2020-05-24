/**
 * @param {string} J
 * @param {string} S
 * @return {number}
 */
var numJewelsInStones = function (J, S) {
    var count = 0;

    for (var i = 0; i < S.length; i++) { //For each character in S.
        for (var j = 0; j < J.length; j++) { //Compare to each character in J.
            var pos = S.indexOf(J[j]);
            if (pos != -1) {
                S = S.replace(S[pos], "");
                count++;
                j--;
            }
        }
    }
    return count;
};