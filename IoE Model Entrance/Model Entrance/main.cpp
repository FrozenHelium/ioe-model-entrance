#include <Windows.h>

LRESULT CALLBACK FrobiWndProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
    switch (uMsg)
    {
    case WM_DESTROY:
        PostQuitMessage(0);
        break;
    default:
        return DefWindowProc(hWnd, uMsg, wParam, lParam);
    }
    return 0;
}

int __stdcall WinMain(HINSTANCE hInst, HINSTANCE hPrev, LPSTR cmdLine, int cmdShow)
{
    WNDCLASSEX wcex = { sizeof(WNDCLASSEX), CS_HREDRAW | CS_VREDRAW, FrobiWndProc, 0, 0, hInst, NULL,
        LoadCursor(NULL, IDC_ARROW), (HBRUSH)(GetStockObject(BLACK_BRUSH)), NULL, "__frobi_model_entrance_window__", NULL };
    if (!RegisterClassEx(&wcex))
    {
        MessageBox(NULL, "failed to register window class", "Error!", MB_OK | MB_ICONERROR);
        return 0;
    }
    HWND hWnd = CreateWindowEx(0, "__frobi_model_entrance_window__", "IoE Model Entrance", WS_OVERLAPPEDWINDOW^WS_SIZEBOX^WS_MAXIMIZEBOX,
        CW_USEDEFAULT, 0, 800, 500, NULL, NULL, hInst, NULL);
    if (hWnd == NULL)
    {
        MessageBox(NULL, "failed to create the window", "Error!", MB_OK | MB_ICONERROR);
        return 1;
    }
    ShowWindow(hWnd, cmdShow);
    MSG msg;
    while (GetMessage(&msg, 0, 0, 0))
    {
        DispatchMessage(&msg);
    }
    return 0;
}