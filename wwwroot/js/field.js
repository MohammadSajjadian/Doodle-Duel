export function getElementRect(element) {
    const rect = element.getBoundingClientRect();

    return {
        left: rect.left,
        top: rect.top,
        width: rect.width,
        height: rect.height
    };
}
export function isPointInsideElement(element, x, y) {
    const rect = element.getBoundingClientRect();

    return (
        x >= rect.left &&
        x <= rect.right &&
        y >= rect.top &&
        y <= rect.bottom
    );
}