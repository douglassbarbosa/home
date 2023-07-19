
import type { Metadata } from 'next'
import { Inter } from 'next/font/google'
import NavBar from '../../components/NavBar'
import CategoryList from '../../components/CategoryList'

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
        <div className='max-w-3xl mx-auto p-4'>
          <NavBar />
          <CategoryList />
          {children}
        </div>
      </body>
    </html>
  )
}
