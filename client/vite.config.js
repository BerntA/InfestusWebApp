import { defineConfig } from 'vite'
import plugin from '@vitejs/plugin-vue'
import path from 'path'

export default defineConfig({
  plugins: [plugin()],
  server: {
    port: 8080,
    proxy: {
      '/api': {
        target: 'http://localhost:5000',
        changeOrigin: true,
        secure: false,
      },
    }
  },
  resolve: {
    alias: [
      { find: '@', replacement: path.resolve(__dirname, 'src') },
    ],
  },
})
