/**
 * @param {string} ransomNote
 * @param {string} magazine
 * @return {boolean}
 */

var ransomNote = "aa";
var magazine = "ab";

var canConstruct = function (ransomNote, magazine) {
    var tempMag = magazine;
    for (var i = 0; i < ransomNote.length; i++) {
        var pos = tempMag.indexOf(ransomNote[i]);
        if (pos == -1) {
            return false;
        } else {
            tempMag = tempMag.replace(tempMag[pos], "");
        }
    }
    return true;
};