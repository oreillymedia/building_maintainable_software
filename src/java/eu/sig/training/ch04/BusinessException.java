package eu.sig.training.ch04;

public class BusinessException extends Exception {
    private static final long serialVersionUID = 1L;

    public BusinessException(String message) {
        super(message);
    }
}
