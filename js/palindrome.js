var isPalindrome = function(x) {
    let palindromeString =x.toString();
    let n = palindromeString.length;
    let i = 0;
    let palindrome= true;
    let mid = parseInt((n/2)+1);
    while (i != mid) {
        if(palindromeString[i] === palindromeString[n-1]){
            n -= 1;
        }
        else{
            palindrome = false;
            break;
        }
        i += 1;
    }
    
    if (palindrome === false) {
        return palindrome;
    }
    else{
        return palindrome;
    }
    };
    const x = 1221;
console.log(isPalindrome(x));