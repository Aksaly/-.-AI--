function addBinary(a: string, b: string): string {
    let carry = 0;
    let result: string[] = [];

    // Ensure both strings are the same length by padding with zeros
    const maxLength = Math.max(a.length, b.length);
    a = a.padStart(maxLength, '0');
    b = b.padStart(maxLength, '0');

    // Iterate through the strings from right to left
    for (let i = maxLength - 1; i >= 0; i--) {
        let bitSum = carry;
        bitSum += a[i] === '1' ? 1 : 0;
        bitSum += b[i] === '1' ? 1 : 0;

        // Append the current bit to the result
        result.push((bitSum % 2).toString());

        // Update carry
        carry = Math.floor(bitSum / 2);
    }

    // If there's a leftover carry, append it
    if (carry) {
        result.push('1');
    }

    // Reverse the result and join it to form the final binary string
    return result.reverse().join('');
}

function isSymmetric(root: TreeNode | null): boolean {
    if (!root) return true;

    function isMirror(left: TreeNode | null, right: TreeNode | null): boolean {
        if (!left && !right) return true;
        if (!left || !right) return false;

        return (left.val === right.val) && 
               isMirror(left.left, right.right) && 
               isMirror(left.right, right.left);
    }

    return isMirror(root.left, root.right);
}

// Test cases
function createTestTree(values: (number | null)[]): TreeNode | null {
    if (!values.length) return null;

    const root = new TreeNode(values[0] as number);
    const queue = [root];
    let i = 1;

    while (queue.length && i < values.length) {
        const node = queue.shift()!;

        if (i < values.length && values[i] !== null) {
            node.left = new TreeNode(values[i] as number);
            queue.push(node.left);
        }
        i++;

        if (i < values.length && values[i] !== null) {
            node.right = new TreeNode(values[i] as number);
            queue.push(node.right);
        }
        i++;
    }

    return root;
}

// Example usage:
const tree = createTestTree([1, 2, 2, 3, 4, 4, 3]);
console.log(isSymmetric(tree)); // Output: true



function addBinary(a: string, b: string): string {
    const num1 = BigInt(`0b${a}`); // Перетворюємо рядок на двійкове число
    const num2 = BigInt(`0b${b}`);
    const sum = num1 + num2; // Додаємо числа
    return sum.toString(2); // Перетворюємо результат у двійковий рядок
}

// Example usage
console.log(addBinary("1010", "1011")); // Виведе "10101"
