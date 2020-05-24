/**
 * @param {number[]} nums
 * @return {number}
 */

var majorityElement = function (nums) {
    var valueMap = new Map([]);
    for (let i = 0; i < nums.length; i++) {
        var key = nums[i];
        if (valueMap.has(key)) {
            var value = valueMap.get(key);
            valueMap.set(key, value + 1);
        } else {
            valueMap.set(key, 1);
        }
    }


    var highestValue = {
        key: null,
        value: 0
    };

    for (const [tKey, tValue] of valueMap.entries()) {
        if (highestValue.value < tValue) {
            highestValue = {
                key: tKey,
                value: tValue
            };
        }
    }
    return highestValue.key;
};