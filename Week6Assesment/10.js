function squareNumbers(n) {
    
    return n.map(num => num * num);
}
const arr1 = [1, 2, 3, 4, 5];
const squareArray = squareNumbers(arr1);

console.log(squareArray); 
