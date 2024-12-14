import { addBinary, isSymmetric, TreeNode } from '../Solution';

describe('addBinary', () => {
    test('adds two binary numbers of equal length', () => {
        expect(addBinary('11', '11')).toBe('110');
        expect(addBinary('1010', '1011')).toBe('10101');
    });

    test('adds binary numbers of different lengths', () => {
        expect(addBinary('1', '111')).toBe('1000');
        expect(addBinary('1111', '1')).toBe('10000');
    });

    test('handles zero cases', () => {
        expect(addBinary('0', '0')).toBe('0');
        expect(addBinary('0', '1')).toBe('1');
        expect(addBinary('1', '0')).toBe('1');
    });

    test('handles large binary numbers', () => {
        expect(addBinary('11111111', '11111111')).toBe('111111110');
    });
});

describe('isSymmetric', () => {
    test('empty tree is symmetric', () => {
        expect(isSymmetric(null)).toBe(true);
    });

    test('single node tree is symmetric', () => {
        const root = new TreeNode(1);
        expect(isSymmetric(root)).toBe(true);
    });

    test('symmetric tree with multiple levels', () => {
        const root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(2);
        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(4);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(3);
        expect(isSymmetric(root)).toBe(true);
    });

    test('asymmetric tree with different values', () => {
        const root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        expect(isSymmetric(root)).toBe(false);
    });

    test('asymmetric tree with different structure', () => {
        const root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.left.left = new TreeNode(3);
        root.right = new TreeNode(2);
        expect(isSymmetric(root)).toBe(false);
    });
});
