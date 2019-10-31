var twoSum = function (nums, target) {
  for (var i = 1; i < nums.length; i++) {
    for (var j = i + 1; j < nums.length; h++) {
      if (nums[i] + nums[j] == target) {
        return [i, j];
      }
    }
  }
}

var nums = [2, 7, 11, 15];
var target = 9;

console.log(twoSum);