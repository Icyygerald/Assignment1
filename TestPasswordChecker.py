from TestPasswordChecker import is_valid_password

def test_password_min_length():
    assert is_valid_password("Password123") == True
    assert is_valid_password("12345678") == True
    assert is_valid_password("short") == False
    assert is_valid_password("") == False
