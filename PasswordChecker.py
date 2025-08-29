def is_valid_password(password):
    """
    Validates if the password meets the minimum length requirement.
    Returns True if password is at least 8 characters long, else False.
    """
    if len(password) < 8:
        return False

    # Add more checks here if needed (uppercase, numbers, etc.)

    return True
