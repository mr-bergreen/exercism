// @ts-check

/**
 * Calculates the sum of the two input arrays.
 *
 * @param {number[]} array1
 * @param {number[]} array2
 * @returns {number} sum of the two arrays
 */
export function twoSum(array1, array2) {
  let num1 = array1.join("");
  let num2 = array2.join("");
  return Number(num1) + Number(num2);
}

/**
 * Checks whether a number is a palindrome.
 *
 * @param {number} value
 * @returns {boolean} whether the number is a palindrome or not
 */
export function luckyNumber(value) {
  let val = String(value)
  let first = 0;
  let last = val.length - 1;
  while (first < last) {
    if (val[first] != val[last])
      return false;
    first += 1
    last -= 1
  }
  return true;
}

/**
 * Determines the error message that should be shown to the user
 * for the given input value.
 *
 * @param {string|null|undefined} input
 * @returns {string} error message
 */
export function errorMessage(input) {
  if (input == null || input == undefined || input == "") {
    return "Required field";
  }
  else if (isNaN(input) || input == "0") {
    return "Must be a number besides 0";
  }
  return ""
}
