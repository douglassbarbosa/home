import './globals.css'
import type { Metadata } from 'next'
import { Inter } from 'next/font/google'
import NavBar from '../components/NavBar'

const inter = Inter({ subsets: ['latin'] })

export const metadata: Metadata = {
  title: 'Porta do Cliente',
  description: 'Gerenciador de Categorias',
}

export default function RootLayout({
  children,
}: {
  children: React.ReactNode
}) {
  return (
    <html lang="pt-BR">
      <body className={inter.className}>
        <div className='max-w-4xl mx-auto p-4'>
          <NavBar />
          <div className='mt-8'>{children}</div>
        </div>
      </body>
    </html>
  )
}
